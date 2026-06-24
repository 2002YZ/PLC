using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace UI
{
    public partial class ForMain : Form
    {
        public ForMain()
        {
            InitializeComponent();
        }

        VisionPro vp = Global.VisionProInstance;  //获取VisionPro单例实例
        PlcOperator plc = Global.PlcOperatorInstance;  //获取PlcOperator单例实例
        Config config = Global.Config;  //获取Config单例实例
        LogHelper log = Global.LogHelper;  //获取LogHelper单例实例

        public FrmStartPage frmStartPage = new FrmStartPage();//获取启动页实例


        /// <summary>
        /// 加载vpp文件
        /// </summary>
        /// <returns></returns>
        public async Task Loadvpp()
        {
            await Task.Run(async () =>
            {
                try
                {
                    await vp.LoadVpp();
                    MessageBox.Show("vpp文件加载成功");
                    AddLog("加载.vpp文件成功");
                    //关闭启动页
                    Invoke(new Action(() =>
                    {
                        frmStartPage.Close();
                        frmStartPage.Dispose();
                    }));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("vpp文件加载失败：" + ex.Message);
                    AddLog("加载.vpp文件失败：" + ex.Message);
                    //关闭启动页
                    Invoke(new Action(() =>
                    {
                        frmStartPage.Close();
                        frmStartPage.Dispose();
                    }));
                }
            });
        }

        /// <summary>
        /// 在ListView中添加日志信息，带时间戳
        /// </summary>
        /// <param name="message"></param>
        public void AddLog(string message)
        {
            if (this.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    ListViewItem listViewItem = new ListViewItem(timestamp);//创建一个新的ListViewItem对象，并设置其文本为时间戳
                    listViewItem.SubItems.Add(message);//添加子项，显示日志信息
                    listViewItem.Text = timestamp;//设置ListViewItem的文本为时间戳
                    listView1.Items.Add(listViewItem); //将ListViewItem添加到ListView控件中
                }));
            }
            else
            {
                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                ListViewItem lvItem = new ListViewItem(time);
                lvItem.SubItems.Add(message);
                lvItem.Text = time;
                listView1.Items.Add(lvItem);
            }
        }



        /// <summary>
        /// 窗体加载事件，加载vpp文件，并显示启动页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForMain_Load(object sender, EventArgs e)
        {
            Loadvpp();
            frmStartPage.ShowDialog();
            //等待vpp文件加载，成功或失败写入日志

            //设置按钮状态
            button_CloseConnectr.Enabled = false;
            button_ConnectPLC.Enabled = false;
            button_C1.Enabled = false;
            button_C2.Enabled = false;
        }

        /// <summary>
        /// 打开实时显示按钮点击事件，调用VisionPro的StartLiveDisplay方法打开实时显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OpenTime_Click(object sender, EventArgs e)
        {
            try
            {
                cogDisplay1.StartLiveDisplay(vp.IdentifyFifo);//打开实时显示
                AddLog("打开实时显示成功");
            }
            catch (Exception ex)
            {

                log.WriteLog("相机实时画面开启失败" + ex.Message, 2);
                AddLog("相机实时画面开启失败" + ex.Message);
            }
        }

        /// <summary>
        /// 关闭实时显示按钮点击事件，调用VisionPro的StopLiveDisplay方法关闭实时显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CloseTime_Click(object sender, EventArgs e)
        {
            try
            {
                cogDisplay1.StopLiveDisplay();//关闭实时显示
                AddLog("关闭实时显示成功");
            }
            catch (Exception ex)
            {

                log.WriteLog("相机实时画面关闭失败" + ex.Message, 2);
                AddLog("相机实时画面关闭失败" + ex.Message);
            }
        }
    }
}
