using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace UI
{
    public partial class FrmNporintJob : Form
    {
        public VisionPro vp = Global.VisionProInstance;
        public LogHelper log = Global.LogHelper;

        /// <summary>
        /// Vpp类表示一个VPP文件的信息，包括名称和路径
        /// </summary>
        public class Vpp
        {
            public string Name { get; set; }
            public string Path { get; set; }

            public int Code { get; set; }
        }

        public FrmNporintJob()
        {
            InitializeComponent();
        }
 
        /// <summary>
        /// 加载标定工具块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox_Vpp.SelectedIndex < 0)
            {
                MessageBox.Show("请选择视觉工程");
                return;
            }

            await vp.LoadVpp();

            int selectedVppCode = Convert.ToInt32(comboBox_Vpp.SelectedValue);

            if (selectedVppCode == 0)
            {
                // 相机与识别
                try
                {
                    await vp.LoadVpp();
                    cogToolBlockEditV21.Subject = vp.NPointCalibrationTB;
                    MessageBox.Show("加载成功");
                    log.WriteLog("加载N点标定工具块成功", 1);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("加载失败：" + ex.Message);
                    log.WriteLog("加载N点标定工具块失败：" + ex.Message, 0);
                }
            }
            else if (selectedVppCode == 1)
            {
                // 相机与机械手
                try
                {
                    await vp.LoadVpp();
                    cogToolBlockEditV21.Subject = vp.IdentifyTB;
                    MessageBox.Show("加载成功");
                    log.WriteLog("加载相机与机械手工具块成功", 1);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("加载失败：" + ex.Message);
                    log.WriteLog("加载相机与机械手工具块失败：" + ex.Message, 0);
                }
            }

        }


        /// <summary>
        /// 保存标定工具块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button2_Click(object sender, EventArgs e)
        {
            string path=Directory.GetCurrentDirectory() + @"\vpp\test.vpp";
            var tool=cogToolBlockEditV21.Subject;
            try
            {
                await vp.Save(tool,path);
                MessageBox.Show("保存成功");
                log.WriteLog("保存工具块成功，路径：" + path, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败：" + ex.Message);
                log.WriteLog("保存工具块失败：" + ex.Message, 0);
            }
        }

        /// <summary>
        /// 窗体加载时，初始化视觉工程下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FrmNporintJob_Load(object sender, EventArgs e)
        {

            List<Vpp> vpps= new List<Vpp>() 
            {
                new Vpp(){Name="相机与识别",Path=vp.NPointCalibrationTbPath,Code=0},
                new Vpp(){Name="相机与机械手",Path=vp.IdentifyTbPath,Code=1}
            };

            comboBox_Vpp.DataSource =vpps;
            comboBox_Vpp.DisplayMember = "Name";
            comboBox_Vpp.ValueMember = "Code";
            comboBox_Vpp.SelectedIndex = -1;
            comboBox_Vpp.Text = "请选择视觉工程";
            log.WriteLog("初始化视觉工程下拉框完成",1);
        }


    }
}
