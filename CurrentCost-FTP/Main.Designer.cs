namespace CurrentCost_Ftp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChangeCode = new System.Windows.Forms.Button();
            this.txtLinesRead = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFilesSent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIOfails = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.grpPortSettings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selPort = new System.Windows.Forms.ComboBox();
            this.selBaud = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatabits = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.stIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpPortSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnChangeCode);
            this.groupBox1.Controls.Add(this.txtLinesRead);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFilesSent);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIOfails);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBatch);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 153);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(104, 126);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(60, 20);
            this.txtCode.TabIndex = 22;
            this.txtCode.Text = "xxxxxxxx";
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Lines Read";
            // 
            // btnChangeCode
            // 
            this.btnChangeCode.Location = new System.Drawing.Point(9, 124);
            this.btnChangeCode.Name = "btnChangeCode";
            this.btnChangeCode.Size = new System.Drawing.Size(81, 23);
            this.btnChangeCode.TabIndex = 21;
            this.btnChangeCode.Text = "Change Code";
            this.btnChangeCode.UseVisualStyleBackColor = true;
            this.btnChangeCode.Click += new System.EventHandler(this.btnChangeCode_Click);
            // 
            // txtLinesRead
            // 
            this.txtLinesRead.Location = new System.Drawing.Point(104, 46);
            this.txtLinesRead.Name = "txtLinesRead";
            this.txtLinesRead.ReadOnly = true;
            this.txtLinesRead.Size = new System.Drawing.Size(60, 20);
            this.txtLinesRead.TabIndex = 18;
            this.txtLinesRead.Text = "0";
            this.txtLinesRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Files Sent";
            // 
            // txtFilesSent
            // 
            this.txtFilesSent.Location = new System.Drawing.Point(104, 72);
            this.txtFilesSent.Name = "txtFilesSent";
            this.txtFilesSent.ReadOnly = true;
            this.txtFilesSent.Size = new System.Drawing.Size(60, 20);
            this.txtFilesSent.TabIndex = 16;
            this.txtFilesSent.Text = "0";
            this.txtFilesSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "I/O Fails";
            // 
            // txtIOfails
            // 
            this.txtIOfails.Location = new System.Drawing.Point(104, 98);
            this.txtIOfails.Name = "txtIOfails";
            this.txtIOfails.ReadOnly = true;
            this.txtIOfails.Size = new System.Drawing.Size(60, 20);
            this.txtIOfails.TabIndex = 14;
            this.txtIOfails.Text = "0";
            this.txtIOfails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Batch Number";
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(104, 20);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(60, 20);
            this.txtBatch.TabIndex = 0;
            this.txtBatch.Text = "20";
            this.txtBatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpPortSettings
            // 
            this.grpPortSettings.Controls.Add(this.label4);
            this.grpPortSettings.Controls.Add(this.label5);
            this.grpPortSettings.Controls.Add(this.selPort);
            this.grpPortSettings.Controls.Add(this.selBaud);
            this.grpPortSettings.Controls.Add(this.label3);
            this.grpPortSettings.Controls.Add(this.txtDatabits);
            this.grpPortSettings.Controls.Add(this.textBox3);
            this.grpPortSettings.Controls.Add(this.label1);
            this.grpPortSettings.Controls.Add(this.label2);
            this.grpPortSettings.Controls.Add(this.textBox2);
            this.grpPortSettings.Location = new System.Drawing.Point(6, 167);
            this.grpPortSettings.Name = "grpPortSettings";
            this.grpPortSettings.Size = new System.Drawing.Size(170, 184);
            this.grpPortSettings.TabIndex = 18;
            this.grpPortSettings.TabStop = false;
            this.grpPortSettings.Text = "Port Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Com Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Baud Rate";
            // 
            // selPort
            // 
            this.selPort.FormattingEnabled = true;
            this.selPort.Location = new System.Drawing.Point(35, 33);
            this.selPort.Name = "selPort";
            this.selPort.Size = new System.Drawing.Size(90, 21);
            this.selPort.TabIndex = 3;
            // 
            // selBaud
            // 
            this.selBaud.FormattingEnabled = true;
            this.selBaud.Items.AddRange(new object[] {
            "2400",
            "9600",
            "57600"});
            this.selBaud.Location = new System.Drawing.Point(35, 73);
            this.selBaud.Name = "selBaud";
            this.selBaud.Size = new System.Drawing.Size(90, 21);
            this.selBaud.TabIndex = 4;
            this.selBaud.Text = "57600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stop Bits";
            // 
            // txtDatabits
            // 
            this.txtDatabits.Location = new System.Drawing.Point(104, 103);
            this.txtDatabits.Name = "txtDatabits";
            this.txtDatabits.ReadOnly = true;
            this.txtDatabits.Size = new System.Drawing.Size(60, 20);
            this.txtDatabits.TabIndex = 5;
            this.txtDatabits.Text = "8";
            this.txtDatabits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(60, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "1";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parity";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(60, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "None";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(182, 12);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(300, 339);
            this.rtbDisplay.TabIndex = 15;
            this.rtbDisplay.Text = "";
            // 
            // btnClosePort
            // 
            this.btnClosePort.Enabled = false;
            this.btnClosePort.Location = new System.Drawing.Point(93, 357);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(83, 23);
            this.btnClosePort.TabIndex = 17;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(6, 357);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(81, 23);
            this.btnOpenPort.TabIndex = 16;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // stIcon
            // 
            this.stIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("stIcon.Icon")));
            this.stIcon.Text = "Current Cost - FTP App";
            this.stIcon.Visible = true;
            this.stIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.stIcon_MouseDoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(376, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 385);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPortSettings);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.btnClosePort);
            this.Controls.Add(this.btnOpenPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "CurrentCost - FTP uploader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPortSettings.ResumeLayout(false);
            this.grpPortSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLinesRead;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFilesSent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIOfails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.GroupBox grpPortSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox selPort;
        private System.Windows.Forms.ComboBox selBaud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatabits;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.NotifyIcon stIcon;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangeCode;
        private System.Windows.Forms.TextBox txtCode;
    }
}

