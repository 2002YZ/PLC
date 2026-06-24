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
        public FrmNporintJob()
        {
            InitializeComponent();
        }
        public VisionPro vp=Global.VisionProInstance;


        /// <summary>
        /// 加载N点标定工具块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await vp.LoadVpp();
                cogToolBlockEditV21.Subject = vp.NPointCalibrationTB;
                MessageBox.Show("加载成功");

            }
            catch (Exception ex)
            {
                MessageBox.Show("加载失败：" + ex.Message);
            }
        }

        /// <summary>
        /// 保存N点标定工具块
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败：" + ex.Message);
            }
        }
    }
}
