using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace UI
{
    public partial class ForConfig : Form
    {
        public ForConfig()
        {
            InitializeComponent();
        }

        Config config= Global.Config;  //获取Config单例实例
        LogHelper log = Global.LogHelper;  //获取LogHelper单例实例


        /// <summary>
        /// 窗体加载事件，初始化配置参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForConfig_Load(object sender, EventArgs e)
        {
            // 初始化基本点参数到文本框
            tBox_BasicPoints_X.Text = config.BaseX.ToString();
            tBox_BasicPoints_Y.Text = config.BaseY.ToString();
            tBox_BasicPoints_R.Text = config.BaseR.ToString();

            // 初始化旋转中心点参数到文本框
            tBox_RotationPoint_X.Text = config.RotateCenterX.ToString();
            tBox_RotationPoint_Y.Text = config.RotateCenterY.ToString();

            // 初始化PLC配置参数到文本框
            tBox_IP.Text = config.PlcIp;
            tBox_Port.Text = config.PlcPort.ToString();

            log.WriteLog("配置窗体加载完成，参数已初始化",1);
        }


        /// <summary>
        /// 提交按钮点击事件，将文本框中的值保存到配置实例中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                // 将基本点的值保存到配置实例中
                config.BaseX = Convert.ToDouble(tBox_BasicPoints_X.Text);
                config.BaseY = Convert.ToDouble(tBox_BasicPoints_Y.Text);
                config.BaseR = Convert.ToDouble(tBox_BasicPoints_R.Text);

                // 将旋转中心点的值保存到配置实例中
                config.RotateCenterX = Convert.ToDouble(tBox_RotationPoint_X.Text);
                config.RotateCenterY = Convert.ToDouble(tBox_RotationPoint_Y.Text);

                // 将PLC配置的值保存到配置实例中
                config.PlcIp = tBox_IP.Text;
                config.PlcPort = Convert.ToInt32(tBox_Port.Text);
                log.WriteLog("配置保存成功", 1);
                MessageBox.Show("配置保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                log.WriteLog("配置保存失败，错误信息：" + ex.Message, 0);
                MessageBox.Show("配置保存失败，请检查输入的值是否正确！\n错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
        }
    }
}
