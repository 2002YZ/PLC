using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;

namespace BAL
{
    public class VisionPro
    {

        #region  单列模式
        //单列模式：保证一个类仅有一个实例，并提供一个访问它的全局访问点。

        //Lazy<T>类提供了一种延迟初始化对象的方式，只有在第一次访问Value属性时才会创建实例，并且是线程安全的。
        private static readonly Lazy<VisionPro> _lazyInstance = new Lazy<VisionPro>(() => new VisionPro());

        public static VisionPro Instance
        {
            get
            {
                return _lazyInstance.Value;
            }
        }

        private VisionPro()
        {
            //在构造函数中初始化VisionPro相关资源
        }


        #endregion


        /// <summary>
        /// 标定文件路径，命名为Identification_tb.vpp，存放在当前目录下的vpp文件夹中
        /// </summary>
        public string IdentifyTbPath = Directory.GetCurrentDirectory() + @"\vpp\Identification_tb.vpp";

        /// <summary>
        /// 标定文件路径，命名为NPointCalibration_tb.vpp，存放在当前目录下的vpp文件夹中
        /// </summary>
        public string NPointCalibrationTbPath = Directory.GetCurrentDirectory() + @"\vpp\NPointCalibration_tb.vpp";

        /// <summary>
        /// CogToolBlock对象，表示标定工具块，加载自IdentifyTbPath路径下的vpp文件
        /// </summary>
        public CogToolBlock IdentifyTB { get; private set; }
        /// <summary>
        /// CogToolBlock对象，表示标定工具块，加载自NPointCalibration路径下的vpp文件
        /// </summary>
        public CogToolBlock NPointCalibrationTB { get; private set; }


        /// <summary>
        /// 获取标定工具块中的CogAcqFifoTool的Operator属性，返回ICogAcqFifo接口对象
        /// </summary>
        public ICogAcqFifo NPointCalibrationFifo
        {
            get
            {
                // 获取NPointCalibrationTB中的第一个CogAcqFifoTool的Operator属性，返回ICogAcqFifo接口对象
                return NPointCalibrationTB?.Tools.OfType<CogAcqFifoTool>().First().Operator;
            }
        }


        /// <summary>
        /// 获取标定工具块中的CogAcqFifoTool的Operator属性，返回ICogAcqFifo接口对象
        /// </summary>
        public ICogAcqFifo IdentifyFifo
        {
            get
            {
                // 获取IdentifyTB中的第一个CogAcqFifoTool的Operator属性，返回ICogAcqFifo接口对象
                return IdentifyTB?.Tools.OfType<CogAcqFifoTool>().First().Operator;
            }
        }


        /// <summary>
        /// 异步加载vpp文件，分别加载IdentifyTbPath和NPointCalibration路径下的vpp文件，
        /// 并将其转换为CogToolBlock对象赋值给IdentifyToolBlock和CalibrationToolBlock属性
        /// </summary>
        /// <returns></returns>
        public async Task LoadVpp()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Global.LogHelper.WriteLog("开始加载vpp文件： " + IdentifyTbPath, 1);
            await Task.Run(() =>
            {
                try
                {
                    IdentifyTB = (CogToolBlock)CogSerializer.LoadObjectFromFile(IdentifyTbPath);
                    NPointCalibrationTB = (CogToolBlock)CogSerializer.LoadObjectFromFile(NPointCalibrationTbPath);

                    sw.Stop();

                    //加载完成后可以在日志中记录成功信息
                    Global.LogHelper.WriteLog("成功加载vpp文件： " + IdentifyTbPath, 1);
                    Global.LogHelper.WriteLog("成功加载vpp文件： " + NPointCalibrationTbPath, 1);
                }
                catch (Exception ex)
                {

                    Global.LogHelper.WriteLog("加载vpp文件失败： " + ex.Message, 0);
                }

            });
        }


        /// <summary>
        /// 保存工具块到vpp文件中，路径由参数path指定，工具块由参数tb指定
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public async Task Save(CogToolBlock tb, string path)
        {
            await Task.Run(() =>
            {
                try
                {
                    CogSerializer.SaveObjectToFile(tb, path);
                    Global.LogHelper.WriteLog("成功保存vpp文件： " + path, 1);
                }
                catch (Exception ex)
                {
                    Global.LogHelper.WriteLog("保存vpp文件失败： " + ex.Message, 0);
                }
            });

        }

    }
}
