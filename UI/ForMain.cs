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
using S7.Net;

namespace UI
{
    public partial class ForMain : Form
    {
        public ForMain()
        {
            InitializeComponent();
        }

        #region 实例对象

        public VisionPro vp = Global.VisionProInstance;  //获取VisionPro单例实例
        public PlcOperator plc = Global.PlcOperatorInstance;  //获取PlcOperator单例实例
        public Config config = Global.Config;  //获取Config单例实例
        public LogHelper log = Global.LogHelper;  //获取LogHelper单例实例

        public FrmStartPage frmStartPage = new FrmStartPage();//获取启动页实例

        #endregion


        #region  公共方法

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
        /// 连接PLC方法，使用S7.Net库连接西门子PLC
        /// </summary>
        /// <returns></returns>
        public async Task ConnectPlc()
        {
            try
            {
                await plc.ConnectAsync(CpuType.S71200, config.PlcIp, config.PlcPort,0,0);
                AddLog("PLC连接成功");
                button_ConnectPLC.Enabled = false;
                button_CloseConnectr.Enabled = true;
                button_C1.Enabled = true;
                button_C2.Enabled = true;
            }
            catch (Exception ex)
            {
                AddLog("PLC连接失败：" + ex.Message);
            }
        }


        #endregion


        #region  按钮和窗体初始化事件

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


        /// <summary>
        /// 连接PLC按钮点击事件，调用ConnectPlc方法连接PLC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_ConnectPLC_Click(object sender, EventArgs e)
        {
            await ConnectPlc();
           
        }


        /// <summary>
        /// 关闭PLC连接按钮点击事件，调用PlcOperator的Disconnect方法断开PLC连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CloseConnectr_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Disconnect();
                AddLog("PLC断开连接成功");
                button_ConnectPLC.Enabled = true;
                button_CloseConnectr.Enabled = false;
            }
            catch (Exception ex)
            {

                AddLog("PLC断开连接失败：" + ex.Message);
            }
            
        }

        #endregion



        #region  界面交互

        /// <summary>
        /// PLC设置菜单点击事件，打开ForConfig窗体进行PLC设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pLC设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForConfig forConfig = new ForConfig();
            forConfig.ShowDialog();
            log.WriteLog("打开PLC设置界面", 1);
        }


        /// <summary>
        /// 九点标定菜单点击事件，打开FrmNporintJob窗体进行九点标定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 九点标定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForNpoint forNpoint = new ForNpoint();
            forNpoint.ShowDialog();
        }


        /// <summary>
        /// 原点标定菜单点击事件，打开FrmCenter窗体进行原点标定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 原点标定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCenter frmCenter=new FrmCenter();
            frmCenter.ShowDialog();
        }


        /// <summary>
        /// 退出系统菜单点击事件，关闭主窗体，退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 作业管理菜单点击事件，打开FrmJob窗体进行作业管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void jobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJob frmJob = new FrmJob();
            frmJob.ShowDialog();
        }


        /// <summary>
        /// 工具菜单点击事件，打开FrmNporintJob窗体进行工具管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBlock工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNporintJob frmNporintJob = new FrmNporintJob();
            frmNporintJob.ShowDialog();
            log.WriteLog("打开工具管理界面", 1);
        }


        #endregion
    }
}
