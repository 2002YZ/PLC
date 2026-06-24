namespace UI
{
    partial class ForMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLC设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基础配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.九点标定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.原点标定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.运动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iO状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报警ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Log = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_OpenTime = new System.Windows.Forms.Button();
            this.button_C2 = new System.Windows.Forms.Button();
            this.button_CloseConnectr = new System.Windows.Forms.Button();
            this.button_ConnectPLC = new System.Windows.Forms.Button();
            this.button_C1 = new System.Windows.Forms.Button();
            this.button_CloseTime = new System.Windows.Forms.Button();
            this.toolBlock工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cogDisplay1 = new Cognex.VisionPro.Display.CogDisplay();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.标定ToolStripMenuItem,
            this.运动ToolStripMenuItem,
            this.其他ToolStripMenuItem,
            this.报警ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1782, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLC设置ToolStripMenuItem,
            this.基础配置ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // pLC设置ToolStripMenuItem
            // 
            this.pLC设置ToolStripMenuItem.Name = "pLC设置ToolStripMenuItem";
            this.pLC设置ToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.pLC设置ToolStripMenuItem.Text = "PLC设置";
            // 
            // 基础配置ToolStripMenuItem
            // 
            this.基础配置ToolStripMenuItem.Name = "基础配置ToolStripMenuItem";
            this.基础配置ToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.基础配置ToolStripMenuItem.Text = "基础配置";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            // 
            // 标定ToolStripMenuItem
            // 
            this.标定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.九点标定ToolStripMenuItem,
            this.原点标定ToolStripMenuItem});
            this.标定ToolStripMenuItem.Name = "标定ToolStripMenuItem";
            this.标定ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.标定ToolStripMenuItem.Text = "标定";
            // 
            // 九点标定ToolStripMenuItem
            // 
            this.九点标定ToolStripMenuItem.Name = "九点标定ToolStripMenuItem";
            this.九点标定ToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.九点标定ToolStripMenuItem.Text = "九点标定";
            // 
            // 原点标定ToolStripMenuItem
            // 
            this.原点标定ToolStripMenuItem.Name = "原点标定ToolStripMenuItem";
            this.原点标定ToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.原点标定ToolStripMenuItem.Text = "中心标定";
            // 
            // 运动ToolStripMenuItem
            // 
            this.运动ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobToolStripMenuItem});
            this.运动ToolStripMenuItem.Name = "运动ToolStripMenuItem";
            this.运动ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.运动ToolStripMenuItem.Text = "运动";
            // 
            // jobToolStripMenuItem
            // 
            this.jobToolStripMenuItem.Name = "jobToolStripMenuItem";
            this.jobToolStripMenuItem.Size = new System.Drawing.Size(121, 28);
            this.jobToolStripMenuItem.Text = "job";
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iO状态ToolStripMenuItem});
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.其他ToolStripMenuItem.Text = "其他";
            // 
            // iO状态ToolStripMenuItem
            // 
            this.iO状态ToolStripMenuItem.Name = "iO状态ToolStripMenuItem";
            this.iO状态ToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.iO状态ToolStripMenuItem.Text = "IO状态";
            // 
            // 报警ToolStripMenuItem
            // 
            this.报警ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBlock工具ToolStripMenuItem});
            this.报警ToolStripMenuItem.Name = "报警ToolStripMenuItem";
            this.报警ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.报警ToolStripMenuItem.Text = "作业";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.cogRecordDisplay1);
            this.panel1.Controls.Add(this.cogDisplay1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 820);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1350, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 820);
            this.panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 648);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Time,
            this.columnHeader_Log});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(426, 622);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Time
            // 
            this.columnHeader_Time.Text = "时间";
            this.columnHeader_Time.Width = 200;
            // 
            // columnHeader_Log
            // 
            this.columnHeader_Log.Text = "日志信息";
            this.columnHeader_Log.Width = 220;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_OpenTime);
            this.groupBox1.Controls.Add(this.button_C2);
            this.groupBox1.Controls.Add(this.button_CloseConnectr);
            this.groupBox1.Controls.Add(this.button_ConnectPLC);
            this.groupBox1.Controls.Add(this.button_C1);
            this.groupBox1.Controls.Add(this.button_CloseTime);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // button_OpenTime
            // 
            this.button_OpenTime.Location = new System.Drawing.Point(36, 44);
            this.button_OpenTime.Name = "button_OpenTime";
            this.button_OpenTime.Size = new System.Drawing.Size(108, 32);
            this.button_OpenTime.TabIndex = 0;
            this.button_OpenTime.Text = "开启实时";
            this.button_OpenTime.UseVisualStyleBackColor = true;
            this.button_OpenTime.Click += new System.EventHandler(this.button_OpenTime_Click);
            // 
            // button_C2
            // 
            this.button_C2.Location = new System.Drawing.Point(301, 115);
            this.button_C2.Name = "button_C2";
            this.button_C2.Size = new System.Drawing.Size(106, 35);
            this.button_C2.TabIndex = 1;
            this.button_C2.Text = "二次测量";
            this.button_C2.UseVisualStyleBackColor = true;
            // 
            // button_CloseConnectr
            // 
            this.button_CloseConnectr.Location = new System.Drawing.Point(173, 115);
            this.button_CloseConnectr.Name = "button_CloseConnectr";
            this.button_CloseConnectr.Size = new System.Drawing.Size(103, 35);
            this.button_CloseConnectr.TabIndex = 2;
            this.button_CloseConnectr.Text = "断开连接";
            this.button_CloseConnectr.UseVisualStyleBackColor = true;
            // 
            // button_ConnectPLC
            // 
            this.button_ConnectPLC.Location = new System.Drawing.Point(36, 115);
            this.button_ConnectPLC.Name = "button_ConnectPLC";
            this.button_ConnectPLC.Size = new System.Drawing.Size(108, 35);
            this.button_ConnectPLC.TabIndex = 3;
            this.button_ConnectPLC.Text = "连接PLC";
            this.button_ConnectPLC.UseVisualStyleBackColor = true;
            // 
            // button_C1
            // 
            this.button_C1.Location = new System.Drawing.Point(301, 44);
            this.button_C1.Name = "button_C1";
            this.button_C1.Size = new System.Drawing.Size(106, 32);
            this.button_C1.TabIndex = 4;
            this.button_C1.Text = "一次测量";
            this.button_C1.UseVisualStyleBackColor = true;
            // 
            // button_CloseTime
            // 
            this.button_CloseTime.Location = new System.Drawing.Point(173, 44);
            this.button_CloseTime.Name = "button_CloseTime";
            this.button_CloseTime.Size = new System.Drawing.Size(103, 32);
            this.button_CloseTime.TabIndex = 5;
            this.button_CloseTime.Text = "停止实时";
            this.button_CloseTime.UseVisualStyleBackColor = true;
            this.button_CloseTime.Click += new System.EventHandler(this.button_CloseTime_Click);
            // 
            // toolBlock工具ToolStripMenuItem
            // 
            this.toolBlock工具ToolStripMenuItem.Name = "toolBlock工具ToolStripMenuItem";
            this.toolBlock工具ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.toolBlock工具ToolStripMenuItem.Text = "ToolBlock工具";
            // 
            // cogDisplay1
            // 
            this.cogDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay1.Dock = System.Windows.Forms.DockStyle.Left;
            this.cogDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay1.Location = new System.Drawing.Point(0, 0);
            this.cogDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay1.MouseWheelSensitivity = 1D;
            this.cogDisplay1.Name = "cogDisplay1";
            this.cogDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay1.OcxState")));
            this.cogDisplay1.Size = new System.Drawing.Size(622, 820);
            this.cogDisplay1.TabIndex = 3;
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(622, 0);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(728, 820);
            this.cogRecordDisplay1.TabIndex = 4;
            // 
            // ForMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 852);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ForMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ForMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 运动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iO状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报警ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_OpenTime;
        private System.Windows.Forms.Button button_C2;
        private System.Windows.Forms.Button button_CloseConnectr;
        private System.Windows.Forms.Button button_ConnectPLC;
        private System.Windows.Forms.Button button_C1;
        private System.Windows.Forms.Button button_CloseTime;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_Time;
        private System.Windows.Forms.ColumnHeader columnHeader_Log;
        private System.Windows.Forms.ToolStripMenuItem pLC设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基础配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 九点标定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 原点标定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolBlock工具ToolStripMenuItem;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private Cognex.VisionPro.Display.CogDisplay cogDisplay1;
    }
}

