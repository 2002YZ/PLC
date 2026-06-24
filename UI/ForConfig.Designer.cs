namespace UI
{
    partial class ForConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBox_BasicPoints_X = new System.Windows.Forms.TextBox();
            this.tBox_BasicPoints_R = new System.Windows.Forms.TextBox();
            this.tBox_RotationPoint_X = new System.Windows.Forms.TextBox();
            this.tBox_RotationPoint_Y = new System.Windows.Forms.TextBox();
            this.tBox_BasicPoints_Y = new System.Windows.Forms.TextBox();
            this.tBox_Port = new System.Windows.Forms.TextBox();
            this.tBox_IP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.button_Submit);
            this.groupBox1.Controls.Add(this.tBox_BasicPoints_Y);
            this.groupBox1.Controls.Add(this.tBox_RotationPoint_Y);
            this.groupBox1.Controls.Add(this.tBox_RotationPoint_X);
            this.groupBox1.Controls.Add(this.tBox_BasicPoints_R);
            this.groupBox1.Controls.Add(this.tBox_BasicPoints_X);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.button_Connect);
            this.groupBox2.Controls.Add(this.tBox_Port);
            this.groupBox2.Controls.Add(this.tBox_IP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(543, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 469);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "基本点X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "旋转中心Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "旋转中心X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "基本点R:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "基本点Y:";
            // 
            // tBox_BasicPoints_X
            // 
            this.tBox_BasicPoints_X.Location = new System.Drawing.Point(213, 71);
            this.tBox_BasicPoints_X.Name = "tBox_BasicPoints_X";
            this.tBox_BasicPoints_X.Size = new System.Drawing.Size(240, 34);
            this.tBox_BasicPoints_X.TabIndex = 5;
            // 
            // tBox_BasicPoints_R
            // 
            this.tBox_BasicPoints_R.Location = new System.Drawing.Point(213, 196);
            this.tBox_BasicPoints_R.Name = "tBox_BasicPoints_R";
            this.tBox_BasicPoints_R.Size = new System.Drawing.Size(240, 34);
            this.tBox_BasicPoints_R.TabIndex = 6;
            // 
            // tBox_RotationPoint_X
            // 
            this.tBox_RotationPoint_X.Location = new System.Drawing.Point(213, 253);
            this.tBox_RotationPoint_X.Name = "tBox_RotationPoint_X";
            this.tBox_RotationPoint_X.Size = new System.Drawing.Size(240, 34);
            this.tBox_RotationPoint_X.TabIndex = 7;
            // 
            // tBox_RotationPoint_Y
            // 
            this.tBox_RotationPoint_Y.Location = new System.Drawing.Point(213, 309);
            this.tBox_RotationPoint_Y.Name = "tBox_RotationPoint_Y";
            this.tBox_RotationPoint_Y.Size = new System.Drawing.Size(240, 34);
            this.tBox_RotationPoint_Y.TabIndex = 8;
            // 
            // tBox_BasicPoints_Y
            // 
            this.tBox_BasicPoints_Y.Location = new System.Drawing.Point(213, 133);
            this.tBox_BasicPoints_Y.Name = "tBox_BasicPoints_Y";
            this.tBox_BasicPoints_Y.Size = new System.Drawing.Size(240, 34);
            this.tBox_BasicPoints_Y.TabIndex = 9;
            // 
            // tBox_Port
            // 
            this.tBox_Port.Location = new System.Drawing.Point(230, 133);
            this.tBox_Port.Name = "tBox_Port";
            this.tBox_Port.Size = new System.Drawing.Size(240, 34);
            this.tBox_Port.TabIndex = 13;
            // 
            // tBox_IP
            // 
            this.tBox_IP.Location = new System.Drawing.Point(230, 71);
            this.tBox_IP.Name = "tBox_IP";
            this.tBox_IP.Size = new System.Drawing.Size(240, 34);
            this.tBox_IP.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "端口号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "IP地址";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(207, 249);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(134, 47);
            this.button_Connect.TabIndex = 14;
            this.button_Connect.Text = "测试连接";
            this.button_Connect.UseVisualStyleBackColor = true;
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(213, 400);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(113, 36);
            this.button_Submit.TabIndex = 15;
            this.button_Submit.Text = "提交";
            this.button_Submit.UseVisualStyleBackColor = true;
            // 
            // ForConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ForConfig";
            this.Text = "ForConfig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.TextBox tBox_BasicPoints_Y;
        private System.Windows.Forms.TextBox tBox_RotationPoint_Y;
        private System.Windows.Forms.TextBox tBox_RotationPoint_X;
        private System.Windows.Forms.TextBox tBox_BasicPoints_R;
        private System.Windows.Forms.TextBox tBox_BasicPoints_X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.TextBox tBox_Port;
        private System.Windows.Forms.TextBox tBox_IP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}