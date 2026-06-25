
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace BAL
{
    public class Config
    {

        #region  单列模式
        //单列模式：保证一个类仅有一个实例，并提供一个访问它的全局访问点。
        private static Config _instance;

        //线程锁
        private static readonly object _lock = new object();

        public static Config Instance
        {
            get
            {
                if (_instance == null)
                {
                    //双重锁定，线程安全的单列模式
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Config();
                        }
                    }
                }
                return _instance;
            }
        }


        /// <summary>
        /// 私有构造函数，防止外部实例化,只支持通过Instance属性访问单列实例
        /// </summary>
        private Config()
        {
            try
            {
               
                IniConfigHelper.IniPath= configPath;//设置配置文件路径

                //基本点x坐标
                string x = IniConfigHelper.ReadIniData("PointConfig", "BaseX", "0", configPath);
                this.baseX = Convert.ToDouble(x);

                //基本点y坐标
                this.baseY = Convert.ToDouble(IniConfigHelper.ReadIniData("PointConfig", "BaseY", "0", configPath));
                //基本点r坐标
                this.baseR = Convert.ToDouble(IniConfigHelper.ReadIniData("PointConfig", "BaseA", "0", configPath));

                //旋转中心x,y坐标
                this.rotateCenterX = Convert.ToDouble(IniConfigHelper.ReadIniData("PointConfig", "RotateCenterX", "0", configPath));
                this.rotateCenterY = Convert.ToDouble(IniConfigHelper.ReadIniData("PointConfig", "RotateCenterY", "0", configPath));

                //PLC配置
                string ip = IniConfigHelper.ReadIniData("PlcConfig", "PlcIp", "127.0.0.1", configPath);//默认值为127.0.0.1
                this.plcIp = ip;

                LogHelper.Instance.WriteLog("配置文件读取成功", 1);



            }
            catch (Exception)
            {
                //写入到日志文件
                LogHelper.Instance.WriteLog("配置文件读取失败", 0);

            }

        }


        #endregion






        /// <summary>
        /// 基准点X坐标
        /// </summary>
        private double baseX;

        public double BaseX
        {
            get { return baseX; }
            set 
            {
                baseX = value;
                IniConfigHelper.WriteIniData("PointConfig", "BaseX", baseX.ToString());
            }
        }

        /// <summary>
        /// 基准点Y坐标
        /// </summary>
        private double baseY;

        public double BaseY
        {
            get { return baseY; }
            set 
            {
                baseY = value;
                IniConfigHelper.WriteIniData("PointConfig", "BaseY", value.ToString());
            }
        }

        /// <summary>
        /// 基准点R坐标
        /// </summary>
        private double baseR;

        public double BaseR
        {
            get { return baseR; }
            set 
            { 
                baseR = value;
                IniConfigHelper.WriteIniData("PointConfig", "BaseR", value.ToString());
            }
        }


        /// <summary>
        /// 旋转中心X坐标
        /// </summary>
        private double rotateCenterX;

        public double RotateCenterX
        {
            get { return rotateCenterX; }
            set 
            {
                rotateCenterX = value;
                IniConfigHelper.WriteIniData("PointConfig", "RotateCenterX", value.ToString());
            }
        }

        /// <summary>
        /// 旋转中心Y坐标
        /// </summary>
        private double rotateCenterY;

        public double RotateCenterY
        {
            get { return rotateCenterY; }
            set 
            { 
                rotateCenterY = value; 
                IniConfigHelper.WriteIniData("PointConfig", "RotateCenterY", value.ToString());
            }
        }

        /// <summary>
        /// plc的IP地址
        /// </summary>
        private string plcIp;

        public string PlcIp
        {
            get { return plcIp; }
            set 
            {
                plcIp  = value; 
                IniConfigHelper.WriteIniData("PlcConfig", "PlcIp", value);
            }
        }


        /// <summary>
        /// plc的端口号
        /// </summary>
        private int plcPort = 102;
        public int PlcPort
        {
            get { return plcPort; }
            set 
            {
                plcPort = value; 
                IniConfigHelper.WriteIniData("PlcConfig", "PlcPort", value.ToString());
            }
        }

        /// <summary>
        /// 配置文件路径，默认在当前目录下的config文件夹中，命名为Config.ini
        /// </summary>
        private string configPath = Directory.GetCurrentDirectory() + @"\config\Config.ini";


    }
}
