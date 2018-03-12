namespace FormI2C
{
    partial class Form1
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.panelSCL = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panelSDA = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelDataSCL = new System.Windows.Forms.Panel();
            this.textSCL = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.panelDataSDA = new System.Windows.Forms.Panel();
            this.textSDA = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.display2 = new FormI2C.Display();
            this.display1 = new FormI2C.Display();
            this.panelTop.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            this.panelSCL.SuspendLayout();
            this.panelSDA.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelDataSCL.SuspendLayout();
            this.panelDataSDA.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.button3);
            this.panelTop.Controls.Add(this.button2);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1184, 44);
            this.panelTop.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "重置";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "暂停";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.Controls.Add(this.panelSCL);
            this.panelDisplay.Controls.Add(this.panelSDA);
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDisplay.Location = new System.Drawing.Point(0, 44);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(1184, 190);
            this.panelDisplay.TabIndex = 1;
            // 
            // panelSCL
            // 
            this.panelSCL.Controls.Add(this.display2);
            this.panelSCL.Controls.Add(this.button5);
            this.panelSCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSCL.Location = new System.Drawing.Point(0, 94);
            this.panelSCL.Name = "panelSCL";
            this.panelSCL.Size = new System.Drawing.Size(1184, 96);
            this.panelSCL.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 96);
            this.button5.TabIndex = 1;
            this.button5.Text = "SCL(时钟):";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panelSDA
            // 
            this.panelSDA.Controls.Add(this.display1);
            this.panelSDA.Controls.Add(this.button4);
            this.panelSDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSDA.Location = new System.Drawing.Point(0, 0);
            this.panelSDA.Name = "panelSDA";
            this.panelSDA.Size = new System.Drawing.Size(1184, 94);
            this.panelSDA.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 94);
            this.button4.TabIndex = 0;
            this.button4.Text = "SDA(数据):";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.panelDataSCL);
            this.panelData.Controls.Add(this.panelDataSDA);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData.Location = new System.Drawing.Point(0, 234);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1184, 86);
            this.panelData.TabIndex = 2;
            // 
            // panelDataSCL
            // 
            this.panelDataSCL.BackColor = System.Drawing.Color.White;
            this.panelDataSCL.Controls.Add(this.textSCL);
            this.panelDataSCL.Controls.Add(this.button7);
            this.panelDataSCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataSCL.Location = new System.Drawing.Point(0, 43);
            this.panelDataSCL.Name = "panelDataSCL";
            this.panelDataSCL.Size = new System.Drawing.Size(1184, 43);
            this.panelDataSCL.TabIndex = 1;
            // 
            // textSCL
            // 
            this.textSCL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSCL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSCL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textSCL.Location = new System.Drawing.Point(106, 11);
            this.textSCL.Name = "textSCL";
            this.textSCL.Size = new System.Drawing.Size(1077, 14);
            this.textSCL.TabIndex = 2;
            this.textSCL.WordWrap = false;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Left;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 43);
            this.button7.TabIndex = 1;
            this.button7.Text = "SCL:";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panelDataSDA
            // 
            this.panelDataSDA.BackColor = System.Drawing.Color.White;
            this.panelDataSDA.Controls.Add(this.textSDA);
            this.panelDataSDA.Controls.Add(this.button6);
            this.panelDataSDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataSDA.Location = new System.Drawing.Point(0, 0);
            this.panelDataSDA.Name = "panelDataSDA";
            this.panelDataSDA.Size = new System.Drawing.Size(1184, 43);
            this.panelDataSDA.TabIndex = 0;
            // 
            // textSDA
            // 
            this.textSDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSDA.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.textSDA.Location = new System.Drawing.Point(106, 13);
            this.textSDA.Name = "textSDA";
            this.textSDA.Size = new System.Drawing.Size(1075, 14);
            this.textSDA.TabIndex = 1;
            this.textSDA.WordWrap = false;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Left;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 43);
            this.button6.TabIndex = 0;
            this.button6.Text = "SDA:";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 241);
            this.panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1184, 219);
            this.textBox1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 219);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "设备离线";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // display2
            // 
            this.display2.BackColor = System.Drawing.Color.White;
            this.display2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display2.Location = new System.Drawing.Point(100, 0);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(1084, 96);
            this.display2.TabIndex = 2;
            // 
            // display1
            // 
            this.display1.BackColor = System.Drawing.Color.White;
            this.display1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display1.Location = new System.Drawing.Point(100, 0);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(1084, 94);
            this.display1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelDisplay.ResumeLayout(false);
            this.panelSCL.ResumeLayout(false);
            this.panelSDA.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelDataSCL.ResumeLayout(false);
            this.panelDataSCL.PerformLayout();
            this.panelDataSDA.ResumeLayout(false);
            this.panelDataSDA.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Panel panelSCL;
        private System.Windows.Forms.Panel panelSDA;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private Display display2;
        private Display display1;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelDataSCL;
        private System.Windows.Forms.Panel panelDataSDA;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textSDA;
        private System.Windows.Forms.TextBox textSCL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}

