namespace UI
{
    partial class FrmCenter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCenter));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelyuan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelthree = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labeltwo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(41, 200);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(181, 33);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "开始转转标定";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(290, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 33);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存圆心坐标";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelyuan
            // 
            this.labelyuan.AutoSize = true;
            this.labelyuan.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelyuan.Location = new System.Drawing.Point(287, 133);
            this.labelyuan.Name = "labelyuan";
            this.labelyuan.Size = new System.Drawing.Size(78, 18);
            this.labelyuan.TabIndex = 10;
            this.labelyuan.Text = "x:00.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(81, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "拟合圆心坐标：";
            // 
            // labelthree
            // 
            this.labelthree.AutoSize = true;
            this.labelthree.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelthree.Location = new System.Drawing.Point(287, 96);
            this.labelthree.Name = "labelthree";
            this.labelthree.Size = new System.Drawing.Size(78, 18);
            this.labelthree.TabIndex = 7;
            this.labelthree.Text = "x:00.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(81, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "三次旋转坐标：";
            // 
            // labeltwo
            // 
            this.labeltwo.AutoSize = true;
            this.labeltwo.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltwo.Location = new System.Drawing.Point(287, 58);
            this.labeltwo.Name = "labeltwo";
            this.labeltwo.Size = new System.Drawing.Size(78, 18);
            this.labeltwo.TabIndex = 4;
            this.labeltwo.Text = "x:00.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(81, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "二次旋转坐标：";
            // 
            // labelone
            // 
            this.labelone.AutoSize = true;
            this.labelone.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelone.Location = new System.Drawing.Point(287, 23);
            this.labelone.Name = "labelone";
            this.labelone.Size = new System.Drawing.Size(78, 18);
            this.labelone.TabIndex = 1;
            this.labelone.Text = "x:00.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(81, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "一次旋转坐标：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLog);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 554);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 15;
            this.lbLog.Location = new System.Drawing.Point(3, 21);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(538, 530);
            this.lbLog.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(773, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 804);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.labelyuan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labelthree);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.labeltwo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "标定";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cogRecordDisplay1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 804);
            this.panel1.TabIndex = 2;
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
            this.cogRecordDisplay1.Location = new System.Drawing.Point(0, 0);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(773, 804);
            this.cogRecordDisplay1.TabIndex = 0;
            // 
            // FrmCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 804);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCenter";
            this.Text = "FrmCenter";
            this.Load += new System.EventHandler(this.FrmCenter_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelyuan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelthree;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labeltwo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
    }
}