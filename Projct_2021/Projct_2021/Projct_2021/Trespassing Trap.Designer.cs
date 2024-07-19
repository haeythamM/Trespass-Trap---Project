namespace Projct_2021
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.Lable2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControllers = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnSnozz = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btbON = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButnDisConct = new System.Windows.Forms.Button();
            this.ButnConct = new System.Windows.Forms.Button();
            this.SecurityBoxInfo = new System.Windows.Forms.TextBox();
            this.ClearButn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmboBxPortFind = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeSnoozeCunt = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupControllers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM8";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(478, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Lable2
            // 
            this.Lable2.AutoSize = true;
            this.Lable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lable2.Location = new System.Drawing.Point(406, 60);
            this.Lable2.Name = "Lable2";
            this.Lable2.Size = new System.Drawing.Size(112, 24);
            this.Lable2.TabIndex = 6;
            this.Lable2.Text = "Security Info";
            this.Lable2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Snow;
            this.Title.Location = new System.Drawing.Point(156, 36);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(220, 29);
            this.Title.TabIndex = 7;
            this.Title.Text = "Trespassing Trap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // groupControllers
            // 
            this.groupControllers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupControllers.BackgroundImage = global::Projct_2021.Properties.Resources._662147;
            this.groupControllers.Controls.Add(this.lblTime);
            this.groupControllers.Controls.Add(this.lblCounter);
            this.groupControllers.Controls.Add(this.btnSnozz);
            this.groupControllers.Controls.Add(this.btnReset);
            this.groupControllers.Controls.Add(this.btbON);
            this.groupControllers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControllers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupControllers.Location = new System.Drawing.Point(26, 60);
            this.groupControllers.Name = "groupControllers";
            this.groupControllers.Size = new System.Drawing.Size(105, 240);
            this.groupControllers.TabIndex = 9;
            this.groupControllers.TabStop = false;
            this.groupControllers.Text = "Controllers";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(37, 214);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(23, 16);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "10";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.BackColor = System.Drawing.Color.Black;
            this.lblCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCounter.Location = new System.Drawing.Point(9, 194);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(87, 16);
            this.lblCounter.TabIndex = 5;
            this.lblCounter.Text = "Time Snooze";
            // 
            // btnSnozz
            // 
            this.btnSnozz.BackColor = System.Drawing.Color.Blue;
            this.btnSnozz.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSnozz.Location = new System.Drawing.Point(14, 114);
            this.btnSnozz.Name = "btnSnozz";
            this.btnSnozz.Size = new System.Drawing.Size(75, 75);
            this.btnSnozz.TabIndex = 4;
            this.btnSnozz.Text = "Snooze  10 minutes";
            this.btnSnozz.UseVisualStyleBackColor = false;
            this.btnSnozz.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Green;
            this.btnReset.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnReset.Location = new System.Drawing.Point(12, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 45);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Security";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btbON
            // 
            this.btbON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btbON.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btbON.Location = new System.Drawing.Point(13, 20);
            this.btbON.Name = "btbON";
            this.btbON.Size = new System.Drawing.Size(75, 35);
            this.btbON.TabIndex = 2;
            this.btbON.Text = "ON";
            this.btbON.UseVisualStyleBackColor = false;
            this.btbON.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.ButnDisConct);
            this.groupBox1.Controls.Add(this.ButnConct);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(26, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 58);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connections";
            // 
            // ButnDisConct
            // 
            this.ButnDisConct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButnDisConct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButnDisConct.Location = new System.Drawing.Point(101, 21);
            this.ButnDisConct.Name = "ButnDisConct";
            this.ButnDisConct.Size = new System.Drawing.Size(75, 23);
            this.ButnDisConct.TabIndex = 6;
            this.ButnDisConct.Text = "Disconnect";
            this.ButnDisConct.UseVisualStyleBackColor = false;
            this.ButnDisConct.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // ButnConct
            // 
            this.ButnConct.BackColor = System.Drawing.Color.Green;
            this.ButnConct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButnConct.Location = new System.Drawing.Point(14, 21);
            this.ButnConct.Name = "ButnConct";
            this.ButnConct.Size = new System.Drawing.Size(75, 23);
            this.ButnConct.TabIndex = 5;
            this.ButnConct.Text = "Connect";
            this.ButnConct.UseVisualStyleBackColor = false;
            this.ButnConct.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // SecurityBoxInfo
            // 
            this.SecurityBoxInfo.BackColor = System.Drawing.Color.Black;
            this.SecurityBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecurityBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityBoxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SecurityBoxInfo.Location = new System.Drawing.Point(391, 87);
            this.SecurityBoxInfo.Multiline = true;
            this.SecurityBoxInfo.Name = "SecurityBoxInfo";
            this.SecurityBoxInfo.Size = new System.Drawing.Size(162, 144);
            this.SecurityBoxInfo.TabIndex = 11;
            this.SecurityBoxInfo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClearButn
            // 
            this.ClearButn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearButn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButn.ForeColor = System.Drawing.Color.White;
            this.ClearButn.Location = new System.Drawing.Point(424, 237);
            this.ClearButn.Name = "ClearButn";
            this.ClearButn.Size = new System.Drawing.Size(90, 32);
            this.ClearButn.TabIndex = 12;
            this.ClearButn.Text = "Clear";
            this.ClearButn.UseVisualStyleBackColor = false;
            this.ClearButn.Click += new System.EventHandler(this.ClearButn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(6, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 32);
            this.button4.TabIndex = 14;
            this.button4.Text = "Find Connections";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1, 380);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // cmboBxPortFind
            // 
            this.cmboBxPortFind.FormattingEnabled = true;
            this.cmboBxPortFind.Location = new System.Drawing.Point(6, 20);
            this.cmboBxPortFind.Name = "cmboBxPortFind";
            this.cmboBxPortFind.Size = new System.Drawing.Size(129, 21);
            this.cmboBxPortFind.TabIndex = 16;
            this.cmboBxPortFind.Text = "Ports Here";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Projct_2021.Properties.Resources._662147;
            this.groupBox2.Controls.Add(this.cmboBxPortFind);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(312, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 93);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connections";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.theProjectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.minimizeWindowToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // minimizeWindowToolStripMenuItem
            // 
            this.minimizeWindowToolStripMenuItem.Name = "minimizeWindowToolStripMenuItem";
            this.minimizeWindowToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.minimizeWindowToolStripMenuItem.Text = "Minimize Window";
            this.minimizeWindowToolStripMenuItem.Click += new System.EventHandler(this.minimizeWindowToolStripMenuItem_Click);
            // 
            // theProjectToolStripMenuItem
            // 
            this.theProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.theProjectToolStripMenuItem1});
            this.theProjectToolStripMenuItem.Name = "theProjectToolStripMenuItem";
            this.theProjectToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.theProjectToolStripMenuItem.Text = "About";
            this.theProjectToolStripMenuItem.Click += new System.EventHandler(this.theProjectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // theProjectToolStripMenuItem1
            // 
            this.theProjectToolStripMenuItem1.Name = "theProjectToolStripMenuItem1";
            this.theProjectToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.theProjectToolStripMenuItem1.Text = "The Project";
            this.theProjectToolStripMenuItem1.Click += new System.EventHandler(this.theProjectToolStripMenuItem1_Click);
            // 
            // TimeSnoozeCunt
            // 
            this.TimeSnoozeCunt.Interval = 60000;
            this.TimeSnoozeCunt.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(478, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Minimize";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Spy Camera Links";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(182, 123);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(165, 24);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Camera Number 1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(182, 174);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(165, 24);
            this.linkLabel2.TabIndex = 22;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Camera Number 2";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Projct_2021.Properties.Resources.iStock_1048265360_e1609854836663;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 397);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ClearButn);
            this.Controls.Add(this.SecurityBoxInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupControllers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Lable2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trespassing Trap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupControllers.ResumeLayout(false);
            this.groupControllers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Lable2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupControllers;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btbON;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButnDisConct;
        private System.Windows.Forms.Button ButnConct;
        private System.Windows.Forms.TextBox SecurityBoxInfo;
        private System.Windows.Forms.Button ClearButn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmboBxPortFind;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer TimeSnoozeCunt;
        private System.Windows.Forms.Button btnSnozz;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem minimizeWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theProjectToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

