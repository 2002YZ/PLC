using BAL;
using Cognex.VisionPro.CalibFix;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmCenter : Form
    {
        public FrmCenter()
        {
            InitializeComponent();
        }

        #region  公共变量
        public VisionPro vp = Global.VisionProInstance;
        public PlcOperator plc = Global.PlcOperatorInstance;
        public LogHelper log = Global.LogHelper;
        public Config config = Global.Config;


        public float x1, y1, x2, y2, x3, y3; // 三个点的坐标

        public float cx, cy; // 圆心坐标


        #endregion

        #region  公共方法

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

                    lbLog.Items.Add(logText);

                    // 自动滚动到最新一行（非常推荐）
                    lbLog.SelectedIndex = lbLog.Items.Count - 1;
                    lbLog.TopIndex = lbLog.Items.Count - 1;
                }));
            }
            else
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // ListBox 直接添加字符串
                string logText = $"[{timestamp}] {message}";

                lbLog.Items.Add(logText);

                // 自动滚动到最新一行（非常推荐）
                lbLog.SelectedIndex = lbLog.Items.Count - 1;
                lbLog.TopIndex = lbLog.Items.Count - 1;
            }
        }


        /// <summary>
        /// 三点求外接圆圆心（全部使用float单精度）
        /// </summary>
        /// <param name="x1,y1">点1</param>
        /// <param name="x2,y2">点2</param>
        /// <param name="x3,y3">点3</param>
        /// <param name="cx">输出圆心X</param>
        /// <param name="cy">输出圆心Y</param>
        /// <returns>true=三点不共线，求解成功；false=三点共线，无外接圆</returns>
        private bool GetCircleCenter(float x1, float y1,
                                           float x2, float y2,
                                           float x3, float y3,
                                           out float cx, out float cy)
        {
            cx = 0;
            cy = 0;

            float a1 = 2 * (x2 - x1);
            float b1 = 2 * (y2 - y1);
            float c1 = x2 * x2 + y2 * y2 - x1 * x1 - y1 * y1;

            float a2 = 2 * (x3 - x2);
            float b2 = 2 * (y3 - y2);
            float c2 = x3 * x3 + y3 * y3 - x2 * x2 - y2 * y2;

            float det = a1 * b2 - a2 * b1;

            if (Math.Abs(det) < 1e-6f)
                return false;

            cx = (b2 * c1 - b1 * c2) / det;
            cy = (a1 * c2 - a2 * c1) / det;

            return true;
        }


        /// <summary>
        /// 旋转拍照测量点数变化事件处理函数
        /// </summary>
        /// <param name="no"></param>
        private void Plc_MeasureNoChanged(int no)
        {
            AddLog($"第{no}次旋转拍照");
            vp.IdentifyTB.Run();

            float x = Convert.ToSingle(vp.IdentifyTB.Outputs["X"].Value);
            float y = Convert.ToSingle(vp.IdentifyTB.Outputs["Y"].Value);

            cogRecordDisplay1.Record = vp.IdentifyTB.CreateLastRunRecord().SubRecords[0];

            if (no == 1)
            {
                x1 = x;
                y1 = y;
                labelone.Text = $"X1: {x1}, Y1: {y1}";
            }
            else if (no == 2)
            {
                x2 = x;
                y2 = y;
                labeltwo.Text = $"X2: {x2}, Y2: {y2}";
            }
            else if (no == 3)
            {
                x3 = x;
                y3 = y;
                labelthree.Text = $"X3: {x3}, Y3: {y3}";
            }

            plc.CenterCalibrationCheckNo = no;

            if (no == 3)
            {

                AddLog("旋转中心标定完成，求圆心");

                GetCircleCenter(x1, y1, x2, y2, x3, y3, out cx, out cy);

                labelyuan.Text =$"X4: {cx}, Y4: {cy}";

                AddLog($"拟合圆圆心坐标：X: {cx}, Y: {cy}");
                log.WriteLog($"拟合圆圆心坐标：X: {cx}, Y: {cy}", 1);

            }
        }


        #endregion



        /// <summary>
        /// 窗体加载事件，订阅PlcOperator的MeasureNoChanged事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCenter_Load(object sender, EventArgs e)
        {
            plc.MeasureNoChanged -= Plc_MeasureNoChanged;
            plc.MeasureNoChanged += Plc_MeasureNoChanged;
        }


        /// <summary>
        /// 保存旋转中心坐标到配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            config.RotateCenterX=cx;
            config.RotateCenterY=cy;
        }
    }
}
