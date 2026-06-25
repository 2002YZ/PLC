using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using S7.Net;

namespace BAL
{
    public class PlcOperator
    {
        #region  单列模式
        //单列模式：保证一个类仅有一个实例，并提供一个访问它的全局访问点。

        //Lazy<T>类提供了一种延迟初始化对象的方式，只有在第一次访问Value属性时才会创建实例，并且是线程安全的。
        private static readonly Lazy<PlcOperator> _lazyInstance = new Lazy<PlcOperator>(() => new PlcOperator());

        public static PlcOperator Instance
        {
            get
            {
                return _lazyInstance.Value;
            }
        }

        private PlcOperator()
        {
            timer = new Timer(300);
            timer.Elapsed += Timer_Elapsed;
        }
        #endregion


        #region PLC-上位机地址常量定义

        //plc发送给上位机的地址常量定义
        public const string PoXAddr = "DB50.DBD20"; // PLC地址常量定义，表示位置X的地址
        public const string PoYAddr = "DB50.DBD24"; // PLC地址常量定义，表示位置Y的地址
        public const string PoZAddr = "DB50.DBD28"; // PLC地址常量定义，表示位置Z的地址
        public const string PoRAddr = "DB50.DBD32"; // PLC地址常量定义，表示位置R的地址

        public const string MeasureNoAddr = "DB50.DBD4";              // PLC地址常量定义，表示测量编号的地址
        public const string NPointCalibrationNoAddr = "DB50.DBD8";    // PLC地址常量定义，表示N点校准编号的地址
        public const string CenterCalibrationNoAddr = "DB50.DBD12";   // PLC地址常量定义，表示中心校准编号的地址




        //上位机发送给PLC的地址常量定义
        public const string OffsetXAddr = "DB51.DBD4";        // x偏移量地址
        public const string OffsetYAddr = "DB51.DBD8";        // y偏移量地址
        public const string OffsetRAddr = "DB51.DBD0";        // r偏移量地址 

        public const string MeasureCheckNoAddr = "DB51.DBD12";                // 测量检查编号地址
        public const string CenterCalibrationCheckNoAddr = "DB51.DBD16";      // 中心校准检查编号地址

        public const string PlaceNoAddr = "DB51.DBD20";                       // 放置编号地址,1 2选择
        public const string NPointCalibrationCheckNoAddr = "DB51.DBD24";      // N点校准检查编号地址

        #endregion


        #region  保存读取plc数据的字段和属性

        /// <summary>
        /// 位置X坐标
        /// </summary>
        public float PosX { get; private set; }

        /// <summary>
        /// 位置Y坐标
        /// </summary>
        public float PosY { get; private set; }

        /// <summary>
        /// 位置Z坐标
        /// </summary>
        public float PosZ { get; private set; }

        /// <summary>
        /// 位置R坐标
        /// </summary>
        public float PosR { get; private set; }


        /// <summary>
        /// 测量编号
        /// </summary>
        private int measureNo;

        /// <summary>
        /// 测量编号改变事件，当MeasureNo属性的值发生变化时触发，传递新的测量编号作为参数
        /// </summary>
        public event Action<int> MeasureNoChanged;
        public int MeasureNo
        {
            get { return measureNo; }
            private set
            {
                if (value != 0 && value != measureNo)
                {
                    measureNo = value;
                    MeasureNoChanged?.Invoke(measureNo);
                }

            }
        }


        /// <summary>
        /// N点校准编号
        /// </summary>
        private int nPointCalibrationNo;

        /// <summary>
        /// N点校准编号改变事件，当NPointCalibrationNo属性的值发生变化时触发，传递新的N点校准编号作为参数
        /// </summary>
        public event Action<int> NPointCalibrationNoChanged;
        public int NPointCalibrationNo
        {
            get { return nPointCalibrationNo; }
            private set
            {
                nPointCalibrationNo = value;
                if (value != 0 && value != nPointCalibrationNo)
                {
                    NPointCalibrationNoChanged?.Invoke(value);
                }
            }
        }


        /// <summary>
        /// 中心校准编号
        /// </summary>
        private int centerCalibrationNo;

        /// <summary>
        /// 中心校准编号改变事件，当CenterCalibrationNo属性的值发生变化时触发，传递新的中心校准编号作为参数
        /// </summary>
        public event Action<int> CenterCalibrationNoChanged;
        public int CenterCalibrationNo
        {
            get { return centerCalibrationNo; }
            private set
            {
                centerCalibrationNo = value;
                if (value != 0 && value != centerCalibrationNo)
                {
                    CenterCalibrationNoChanged?.Invoke(value);
                }
            }
        }

        #endregion


        #region 拍照编号确认属性

        /// <summary>
        /// 拍照编号确认属性，表示当前的测量检查编号，当设置该属性时，会将值写入PLC的MeasureCheckNoAddr地址
        /// </summary>
        private int measureCheckNo;
        public int MeasureCheckNo
        {
            get { return measureCheckNo; }
            set
            {
                measureCheckNo = value;
                WritePlc(MeasureCheckNoAddr, value);
            }
        }

        /// <summary>
        /// 中心校准编号确认属性，表示当前的中心校准检查编号，当设置该属性时，会将值写入PLC的CenterCalibrationCheckNoAddr地址
        /// </summary>
        private int centerCalibrationCheckNo;
        public int CenterCalibrationCheckNo
        {
            get { return centerCalibrationCheckNo; }
            set
            {
                centerCalibrationCheckNo = value;
                WritePlc(CenterCalibrationCheckNoAddr, value);
            }
        }

        /// <summary>
        /// N点校准编号确认属性，表示当前的N点校准检查编号，当设置该属性时，会将值写入PLC的NPointCalibrationCheckNoAddr地址
        /// </summary>
        private int nPointCalibrationCheckNo;
        public int NPointCalibrationCheckNo
        {
            get { return nPointCalibrationCheckNo; }
            set
            {
                nPointCalibrationCheckNo = value;
                WritePlc(NPointCalibrationCheckNoAddr, value);
            }
        }

        #endregion


        #region 机械坐标矫正后的偏移量属性

        /// <summary>
        /// 放置编号，表示当前的放置位置编号，可以是1或2，当设置该属性时，会将值写入PLC的PlaceNoAddr地址
        /// </summary>
        private float placeNo; 

        public float PlaceNo
        {
            get { return placeNo; }
            set 
            {
                placeNo = value; 
                WritePlc(PlaceNoAddr, (uint)value); // 将放置编号写入PLC
            }
        }


        /// <summary>
        /// 位置X坐标
        /// </summary>
        private float offsetX;
        public float OffsetX 
        { 
            get { return offsetX; } 
            private set 
            {
                offsetX = value;
                WritePlc(OffsetXAddr, value);
            } 
        }


        /// <summary>
        /// 位置Y坐标
        /// </summary>
        private float offsetY;
        public float OffsetY
        {
            get { return offsetY; }
            private set
            {
                offsetY = value;
                WritePlc(OffsetYAddr, value);
            }
        }

        
        /// <summary>
        /// 位置R坐标
        /// </summary>
        private float offsetR;
        public float OffsetR
        {
            get { return offsetR; }
            private set
            {
                offsetR = value;
                WritePlc(OffsetRAddr, value);
            }
        }

        #endregion



        #region  公共字段

        private Plc plc = null;      // S7.Net.Plc对象，用于与PLC进行通信
        private Timer timer = null;  // System.Threading.Timer对象，用于定时读取PLC数据

        #endregion


        #region  定时器轮询操作(读取)

        /// <summary>
        /// 定时器Elapsed事件处理程序，用于定时读取PLC数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            ReadPlcData();
        }

        /// <summary>
        /// 读取PLC数据的方法，如果PLC对象不为空且已连接，则从PLC中读取位置坐标、测量编号、N点校准编号和中心校准编号，并更新相应的属性值
        /// </summary>
        public void ReadPlcData()
        {
            if (plc != null && plc.IsConnected)
            {
                try
                {
                    // 读取PLC数据
                    PosX = ((uint)plc.Read(PoXAddr)).ConvertToFloat();
                    PosY = ((uint)plc.Read(PoYAddr)).ConvertToFloat();
                    PosZ = ((uint)plc.Read(PoZAddr)).ConvertToFloat();
                    PosR = ((uint)plc.Read(PoRAddr)).ConvertToFloat();
                    MeasureNo = Convert.ToInt32(plc.Read(MeasureNoAddr));
                    NPointCalibrationNo = Convert.ToInt32(plc.Read(NPointCalibrationNoAddr));
                    CenterCalibrationNo = Convert.ToInt32(plc.Read(CenterCalibrationNoAddr));
                }
                catch (Exception ex)
                {
                    Global.LogHelper.WriteLog($"读取PLC数据失败，错误信息：{ex.Message}", 2);
                }
            }
        }

        #endregion


        #region 公共方法

        /// <summary>
        /// 连接PLC的方法，使用指定的CPU类型、IP地址、端口号、机架号和插槽号进行连接
        /// </summary>
        /// <param name="cpuType"></param>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="rack"></param>
        /// <param name="slot"></param>
        public async Task ConnectAsync(CpuType cpuType, string ip, int port, short rack, short slot)
        {
            // 如果PLC对象不为空且已连接，则先断开连接
            Disconnect();

            try
            {
                plc = new Plc(cpuType, ip, port, rack, slot);
                await plc.OpenAsync();

                //日志
                Global.LogHelper.WriteLog($"PLC连接成功，CPU类型：{cpuType}，IP地址：{ip}，端口号：{port}，机架号：{rack}，插槽号：{slot}", 1);

                // 启动定时器，开始定时读取PLC数据
                timer.Start();
                Global.LogHelper.WriteLog("PLC定时读取数据已启动", 1);
            }
            catch (Exception ex)
            {
                Global.LogHelper.WriteLog($"PLC连接失败，错误信息：{ex.Message}", 2);
            }

        }


        /// <summary>
        /// 断开PLC连接的方法，如果PLC对象不为空且已连接，则关闭连接并释放资源，同时停止定时器
        /// </summary>
        public void Disconnect()
        {
            if (plc != null && plc.IsConnected)
            {
                plc.Close();
                plc = null;

                Global.LogHelper.WriteLog("PLC已断开连接", 1);

                // 停止定时器，停止读取PLC数据
                timer.Stop();
                Global.LogHelper.WriteLog("PLC定时读取数据已停止", 1);
            }
        }

        /// <summary>
        /// 向PLC写入数据的方法，如果PLC对象不为空且已连接，则将指定的值写入指定的地址，并捕获异常记录日志
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        public void WritePlc(string address, object value)
        {
            if (plc != null && plc.IsConnected)
            {
                try
                {
                    plc.Write(address, value);
                }
                catch (Exception ex)
                {
                    Global.LogHelper.WriteLog($"写入PLC数据失败，错误信息：{ex.Message}", 2);
                }
            }
        }


        #endregion
    }

}
