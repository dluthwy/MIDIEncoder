namespace MidiEncoder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OpenFile = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.btnSerialPort = new System.Windows.Forms.Button();
            this.cbxStopBit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCheckBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDataBit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSerialName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbSend = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClearRec = new System.Windows.Forms.Button();
            this.rabRecHex = new System.Windows.Forms.RadioButton();
            this.rabRecAscii = new System.Windows.Forms.RadioButton();
            this.btnClearSend = new System.Windows.Forms.Button();
            this.rabSendHex = new System.Windows.Forms.RadioButton();
            this.rabSendAscii = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbReceive = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listMusicView = new System.Windows.Forms.ListView();
            this.colNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelSetting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenFile.Location = new System.Drawing.Point(1046, 572);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(124, 40);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "加载文件";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(824, 46);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(348, 248);
            this.rtbLog.TabIndex = 1;
            this.rtbLog.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(824, 572);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(124, 40);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "播放";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // panelSetting
            // 
            this.panelSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSetting.Controls.Add(this.btnSerialPort);
            this.panelSetting.Controls.Add(this.cbxStopBit);
            this.panelSetting.Controls.Add(this.label5);
            this.panelSetting.Controls.Add(this.cbxCheckBit);
            this.panelSetting.Controls.Add(this.label4);
            this.panelSetting.Controls.Add(this.cbxDataBit);
            this.panelSetting.Controls.Add(this.label3);
            this.panelSetting.Controls.Add(this.cbxBaud);
            this.panelSetting.Controls.Add(this.label2);
            this.panelSetting.Controls.Add(this.cbxSerialName);
            this.panelSetting.Controls.Add(this.label1);
            this.panelSetting.Location = new System.Drawing.Point(12, 12);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(290, 341);
            this.panelSetting.TabIndex = 3;
            // 
            // btnSerialPort
            // 
            this.btnSerialPort.BackColor = System.Drawing.Color.Green;
            this.btnSerialPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSerialPort.Location = new System.Drawing.Point(27, 282);
            this.btnSerialPort.Name = "btnSerialPort";
            this.btnSerialPort.Size = new System.Drawing.Size(237, 54);
            this.btnSerialPort.TabIndex = 4;
            this.btnSerialPort.Text = "打开串口";
            this.btnSerialPort.UseVisualStyleBackColor = false;
            this.btnSerialPort.Click += new System.EventHandler(this.BtnSerialPort_Click);
            // 
            // cbxStopBit
            // 
            this.cbxStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStopBit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxStopBit.FormattingEnabled = true;
            this.cbxStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbxStopBit.Location = new System.Drawing.Point(74, 226);
            this.cbxStopBit.Name = "cbxStopBit";
            this.cbxStopBit.Size = new System.Drawing.Size(208, 36);
            this.cbxStopBit.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "停止位";
            // 
            // cbxCheckBit
            // 
            this.cbxCheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCheckBit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxCheckBit.FormattingEnabled = true;
            this.cbxCheckBit.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbxCheckBit.Location = new System.Drawing.Point(74, 172);
            this.cbxCheckBit.Name = "cbxCheckBit";
            this.cbxCheckBit.Size = new System.Drawing.Size(208, 36);
            this.cbxCheckBit.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "校验位";
            // 
            // cbxDataBit
            // 
            this.cbxDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataBit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxDataBit.FormattingEnabled = true;
            this.cbxDataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.cbxDataBit.Location = new System.Drawing.Point(74, 117);
            this.cbxDataBit.Name = "cbxDataBit";
            this.cbxDataBit.Size = new System.Drawing.Size(208, 36);
            this.cbxDataBit.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "数据位";
            // 
            // cbxBaud
            // 
            this.cbxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaud.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxBaud.FormattingEnabled = true;
            this.cbxBaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cbxBaud.Location = new System.Drawing.Point(74, 63);
            this.cbxBaud.Name = "cbxBaud";
            this.cbxBaud.Size = new System.Drawing.Size(208, 36);
            this.cbxBaud.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "波特率";
            // 
            // cbxSerialName
            // 
            this.cbxSerialName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSerialName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxSerialName.FormattingEnabled = true;
            this.cbxSerialName.Location = new System.Drawing.Point(74, 8);
            this.cbxSerialName.Name = "cbxSerialName";
            this.cbxSerialName.Size = new System.Drawing.Size(208, 36);
            this.cbxSerialName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "串口名";
            // 
            // rtbSend
            // 
            this.rtbSend.Location = new System.Drawing.Point(316, 452);
            this.rtbSend.Name = "rtbSend";
            this.rtbSend.Size = new System.Drawing.Size(486, 160);
            this.rtbSend.TabIndex = 4;
            this.rtbSend.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(314, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "发送区";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnClearRec);
            this.panel1.Controls.Add(this.rabRecHex);
            this.panel1.Controls.Add(this.rabRecAscii);
            this.panel1.Location = new System.Drawing.Point(12, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 118);
            this.panel1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(21, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "接受码";
            // 
            // btnClearRec
            // 
            this.btnClearRec.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearRec.Location = new System.Drawing.Point(26, 64);
            this.btnClearRec.Name = "btnClearRec";
            this.btnClearRec.Size = new System.Drawing.Size(238, 34);
            this.btnClearRec.TabIndex = 15;
            this.btnClearRec.Text = "清空接收";
            this.btnClearRec.UseVisualStyleBackColor = true;
            this.btnClearRec.Click += new System.EventHandler(this.BtnClearRec_Click);
            // 
            // rabRecHex
            // 
            this.rabRecHex.AutoSize = true;
            this.rabRecHex.Checked = true;
            this.rabRecHex.Location = new System.Drawing.Point(202, 22);
            this.rabRecHex.Name = "rabRecHex";
            this.rabRecHex.Size = new System.Drawing.Size(60, 22);
            this.rabRecHex.TabIndex = 18;
            this.rabRecHex.TabStop = true;
            this.rabRecHex.Text = "HEX";
            this.rabRecHex.UseVisualStyleBackColor = true;
            this.rabRecHex.CheckedChanged += new System.EventHandler(this.RabRecHex_CheckedChanged);
            // 
            // rabRecAscii
            // 
            this.rabRecAscii.AutoSize = true;
            this.rabRecAscii.Location = new System.Drawing.Point(117, 22);
            this.rabRecAscii.Name = "rabRecAscii";
            this.rabRecAscii.Size = new System.Drawing.Size(78, 22);
            this.rabRecAscii.TabIndex = 17;
            this.rabRecAscii.Text = "ASCII";
            this.rabRecAscii.UseVisualStyleBackColor = true;
            this.rabRecAscii.CheckedChanged += new System.EventHandler(this.RabRecAscii_CheckedChanged);
            // 
            // btnClearSend
            // 
            this.btnClearSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearSend.Location = new System.Drawing.Point(27, 63);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(237, 34);
            this.btnClearSend.TabIndex = 19;
            this.btnClearSend.Text = "清空发送";
            this.btnClearSend.UseVisualStyleBackColor = true;
            this.btnClearSend.Click += new System.EventHandler(this.BtnClearSend_Click);
            // 
            // rabSendHex
            // 
            this.rabSendHex.AutoSize = true;
            this.rabSendHex.Checked = true;
            this.rabSendHex.Location = new System.Drawing.Point(202, 18);
            this.rabSendHex.Name = "rabSendHex";
            this.rabSendHex.Size = new System.Drawing.Size(60, 22);
            this.rabSendHex.TabIndex = 21;
            this.rabSendHex.TabStop = true;
            this.rabSendHex.Text = "HEX";
            this.rabSendHex.UseVisualStyleBackColor = true;
            this.rabSendHex.CheckedChanged += new System.EventHandler(this.RabSendHex_CheckedChanged);
            // 
            // rabSendAscii
            // 
            this.rabSendAscii.AutoSize = true;
            this.rabSendAscii.Location = new System.Drawing.Point(117, 18);
            this.rabSendAscii.Name = "rabSendAscii";
            this.rabSendAscii.Size = new System.Drawing.Size(78, 22);
            this.rabSendAscii.TabIndex = 20;
            this.rabSendAscii.Text = "ASCII";
            this.rabSendAscii.UseVisualStyleBackColor = true;
            this.rabSendAscii.CheckedChanged += new System.EventHandler(this.RabSendAscii_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.rabSendHex);
            this.panel2.Controls.Add(this.btnClearSend);
            this.panel2.Controls.Add(this.rabSendAscii);
            this.panel2.Location = new System.Drawing.Point(12, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 114);
            this.panel2.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(22, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "发送码";
            // 
            // rtbReceive
            // 
            this.rtbReceive.Location = new System.Drawing.Point(316, 48);
            this.rtbReceive.Name = "rtbReceive";
            this.rtbReceive.Size = new System.Drawing.Size(486, 367);
            this.rtbReceive.TabIndex = 23;
            this.rtbReceive.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(314, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "接收区";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(819, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "日志";
            // 
            // listMusicView
            // 
            this.listMusicView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum,
            this.colName,
            this.colSize,
            this.colStatus});
            this.listMusicView.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listMusicView.GridLines = true;
            this.listMusicView.Location = new System.Drawing.Point(824, 320);
            this.listMusicView.Name = "listMusicView";
            this.listMusicView.Size = new System.Drawing.Size(348, 236);
            this.listMusicView.TabIndex = 26;
            this.listMusicView.UseCompatibleStateImageBehavior = false;
            this.listMusicView.View = System.Windows.Forms.View.Details;
            // 
            // colNum
            // 
            this.colNum.Tag = "";
            this.colNum.Text = "序号";
            this.colNum.Width = 38;
            // 
            // colName
            // 
            this.colName.Text = "歌曲名";
            this.colName.Width = 59;
            // 
            // colSize
            // 
            this.colSize.Text = "大小";
            this.colSize.Width = 59;
            // 
            // colStatus
            // 
            this.colStatus.Text = "状态";
            this.colStatus.Width = 72;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 637);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip.Size = new System.Drawing.Size(1184, 29);
            this.statusStrip.TabIndex = 27;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(195, 24);
            this.statusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 666);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.listMusicView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbReceive);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbSend);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.OpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MidiEncoder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Button btnSerialPort;
        private System.Windows.Forms.ComboBox cbxStopBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCheckBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxDataBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxBaud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSerialName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearRec;
        private System.Windows.Forms.RadioButton rabRecHex;
        private System.Windows.Forms.RadioButton rabRecAscii;
        private System.Windows.Forms.Button btnClearSend;
        private System.Windows.Forms.RadioButton rabSendHex;
        private System.Windows.Forms.RadioButton rabSendAscii;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbReceive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listMusicView;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colNum;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.IO.Ports.SerialPort serialPort;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

