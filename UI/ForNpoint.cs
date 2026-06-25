using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.CalibFix;
using BAL;
using Cognex.VisionPro.Exceptions;

namespace UI
{
    public partial class ForNpoint : Form
    {
        public ForNpoint()
        {
            InitializeComponent();

            //获取九点标定计算工具
            calib = GetTool() != null ? GetTool().Calibration : null;

            AddLog("准备九点标定");
        }

        #region  公共变量
        public VisionPro vp = Global.VisionProInstance;           
        public PlcOperator plc = Global.PlcOperatorInstance;
        public LogHelper log = Global.LogHelper;
        public CogCalibNPointToNPoint calib = null;  //九点标定计算工具
        #endregion



        #region  公共方法

        /// <summary>
        /// 循环遍历获取九点标定工具
        /// </summary>
        /// <returns></returns>
        public CogCalibNPointToNPointTool GetTool()
        {
            CogCalibNPointToNPointTool tool = null;
            foreach (var t in vp.IdentifyTB.Tools)
            {
                if (t is CogCalibNPointToNPoint)
                {
                    tool = t as CogCalibNPointToNPointTool;
                    break;
                }
            }
            return tool;
        }


        /// <summary>
        /// 在ListBox中添加日志信息，带时间戳
        /// </summary>
        /// <param name="message"></param>
        public void AddLog(string message)
        {
            if (this.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    // ListBox 直接添加字符串
                    string logText = $"[{timestamp}] {message}";

                    listBox1.Items.Add(logText);

                    // 自动滚动到最新一行（非常推荐）
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                }));
            }
            else
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // ListBox 直接添加字符串
                string logText = $"[{timestamp}] {message}";

                listBox1.Items.Add(logText);

                // 自动滚动到最新一行（非常推荐）
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
        }



        #endregion



        /// <summary>
        /// 清除九点标定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                AddLog("开始清除");
                for (int i = 0; i < calib.NumPoints; i++)
                {
                    calib.DeletePointPair(0);
                    i--;
                }
                AddLog("清除完成");
            }
            catch (Exception ex)
            {

                AddLog("清除失败"+ex.Message);
            }
        }


        /// <summary>
        /// 开始九点标定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //订阅PLC的NPointCalibrationNoChanged事件，确保不会重复订阅
            plc.NPointCalibrationNoChanged -= plc_NPointCalibrationNoChanged;
            plc.NPointCalibrationNoChanged += plc_NPointCalibrationNoChanged;
        }

        /// <summary>
        /// PLC的NPointCalibrationNoChanged事件处理方法，当PLC的拍照编号发生变化时触发
        /// </summary>
        /// <param name="no"></param>
        private async  void plc_NPointCalibrationNoChanged(int no)
        {
            AddLog($"当前拍照编号：{no},第{no}次拍照");
            try
            {
                //运行九点标定工具块
                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        //在UI线程中执行的代码
                        vp.NPointCalibrationTB.Run();//运行九点标定工具块

                    }));
                }
                else
                {
                    vp.NPointCalibrationTB.Run();//运行九点标定工具块
                }

                //获取目标物的像素坐标X和Y
                double x = (double)vp.NPointCalibrationTB.Outputs["X"].Value;
                double y = (double)vp.NPointCalibrationTB.Outputs["Y"].Value;

                ////获取最后一次运行的记录，并显示在cogRecordDisplay1控件中
                cogRecordDisplay1.Record=vp.NPointCalibrationTB.CreateLastRunRecord().SubRecords[0];

                //将像素坐标和实际坐标添加到九点标定工具中
                calib.AddPointPair(x,y,plc.PosX,plc.PosY);

                AddLog($"添加点对，像素坐标：x:{x} ,y:{y} 机械坐标：X={plc.PosX},Y={plc.PosY}");

                //更新PLC的NPointCalibrationCheckNo
                plc.NPointCalibrationCheckNo = no;

                //如果九点标定点数大于等于9，则保存标定工具块
                if (calib.NumPoints >= 9)
                {
                    AddLog("九点标定完成");
                    if (calib.ComputedRMSError > 30)
                    {
                        AddLog($"九点标定误差过大，RMS误差为：{calib.ComputedRMSError}");
                    }

                    await vp.Save(vp.NPointCalibrationTB,vp.NPointCalibrationTbPath);

                    AddLog($"九点标定工具块保存成功，路径为：{vp.NPointCalibrationTbPath}");
                    log.WriteLog($"九点标定工具块保存成功，路径为：{vp.NPointCalibrationTbPath}", 1);
                }

            }
            catch (Exception ex)
            {

               AddLog($"第{no}次拍照失败，错误信息：{ex.Message}");
                log.WriteLog($"第{no}次拍照失败，错误信息：{ex.Message}", 0);
            }
        }
    }
}
