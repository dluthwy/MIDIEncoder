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
            this.OpenFile = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnPlay = new System.Windows.Forms.Button();
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
            this.btnClearRec = new System.Windows.Forms.Button();
            this.rabRecHex = new System.Windows.Forms.RadioButton();
            this.rabRecAscii = new System.Windows.Forms.RadioButton();
            this.btnClearSend = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbReceive = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listSong = new System.Windows.Forms.ListView();
            this.colNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelSetting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenFile.Location = new System.Drawing.Point(697, 381);
            this.OpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(83, 27);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "加载文件";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(549, 31);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(233, 167);
            this.rtbLog.TabIndex = 1;
            this.rtbLog.Text = "";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlay.Location = new System.Drawing.Point(549, 381);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(83, 27);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "发送";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
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
            this.panelSetting.Location = new System.Drawing.Point(8, 8);
            this.panelSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(194, 228);
            this.panelSetting.TabIndex = 3;
            // 
            // btnSerialPort
            // 
            this.btnSerialPort.BackColor = System.Drawing.Color.Green;
            this.btnSerialPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSerialPort.Location = new System.Drawing.Point(18, 188);
            this.btnSerialPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSerialPort.Name = "btnSerialPort";
            this.btnSerialPort.Size = new System.Drawing.Size(158, 36);
            this.btnSerialPort.TabIndex = 4;
            this.btnSerialPort.Text = "打开串口";
            this.btnSerialPort.UseVisualStyleBackColor = false;
            // 
            // cbxStopBit
            // 
            this.cbxStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStopBit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxStopBit.FormattingEnabled = true;
            this.cbxStopBit.Location = new System.Drawing.Point(49, 151);
            this.cbxStopBit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxStopBit.Name = "cbxStopBit";
            this.cbxStopBit.Size = new System.Drawing.Size(140, 28);
            this.cbxStopBit.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(2, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "停止位";
            // 
            // cbxCheckBit
            // 
            this.cbxCheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCheckBit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxCheckBit.FormattingEnabled = true;
            this.cbxCheckBit.Location = new System.Drawing.Point(49, 115);
            this.cbxCheckBit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCheckBit.Name = "cbxCheckBit";
            this.cbxCheckBit.Size = new System.Drawing.Size(140, 28);
            this.cbxCheckBit.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(2, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "校验位";
            // 
            // cbxDataBit
            // 
            this.cbxDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataBit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxDataBit.FormattingEnabled = true;
            this.cbxDataBit.Location = new System.Drawing.Point(49, 78);
            this.cbxDataBit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDataBit.Name = "cbxDataBit";
            this.cbxDataBit.Size = new System.Drawing.Size(140, 28);
            this.cbxDataBit.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(2, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "数据位";
            // 
            // cbxBaud
            // 
            this.cbxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaud.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxBaud.FormattingEnabled = true;
            this.cbxBaud.Location = new System.Drawing.Point(49, 42);
            this.cbxBaud.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxBaud.Name = "cbxBaud";
            this.cbxBaud.Size = new System.Drawing.Size(140, 28);
            this.cbxBaud.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(2, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "波特率";
            // 
            // cbxSerialName
            // 
            this.cbxSerialName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSerialName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxSerialName.FormattingEnabled = true;
            this.cbxSerialName.Location = new System.Drawing.Point(49, 5);
            this.cbxSerialName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSerialName.Name = "cbxSerialName";
            this.cbxSerialName.Size = new System.Drawing.Size(140, 28);
            this.cbxSerialName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "串口名";
            // 
            // rtbSend
            // 
            this.rtbSend.Location = new System.Drawing.Point(211, 301);
            this.rtbSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbSend.Name = "rtbSend";
            this.rtbSend.Size = new System.Drawing.Size(325, 108);
            this.rtbSend.TabIndex = 4;
            this.rtbSend.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(209, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
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
            this.panel1.Location = new System.Drawing.Point(8, 246);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 79);
            this.panel1.TabIndex = 16;
            // 
            // btnClearRec
            // 
            this.btnClearRec.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearRec.Location = new System.Drawing.Point(17, 43);
            this.btnClearRec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearRec.Name = "btnClearRec";
            this.btnClearRec.Size = new System.Drawing.Size(159, 23);
            this.btnClearRec.TabIndex = 15;
            this.btnClearRec.Text = "清空接收";
            this.btnClearRec.UseVisualStyleBackColor = true;
            // 
            // rabRecHex
            // 
            this.rabRecHex.AutoSize = true;
            this.rabRecHex.Location = new System.Drawing.Point(135, 15);
            this.rabRecHex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rabRecHex.Name = "rabRecHex";
            this.rabRecHex.Size = new System.Drawing.Size(41, 16);
            this.rabRecHex.TabIndex = 18;
            this.rabRecHex.TabStop = true;
            this.rabRecHex.Text = "HEX";
            this.rabRecHex.UseVisualStyleBackColor = true;
            // 
            // rabRecAscii
            // 
            this.rabRecAscii.AutoSize = true;
            this.rabRecAscii.Location = new System.Drawing.Point(78, 15);
            this.rabRecAscii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rabRecAscii.Name = "rabRecAscii";
            this.rabRecAscii.Size = new System.Drawing.Size(53, 16);
            this.rabRecAscii.TabIndex = 17;
            this.rabRecAscii.TabStop = true;
            this.rabRecAscii.Text = "ASCII";
            this.rabRecAscii.UseVisualStyleBackColor = true;
            // 
            // btnClearSend
            // 
            this.btnClearSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearSend.Location = new System.Drawing.Point(18, 42);
            this.btnClearSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(158, 23);
            this.btnClearSend.TabIndex = 19;
            this.btnClearSend.Text = "清空发送";
            this.btnClearSend.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(135, 12);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 16);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "HEX";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(78, 12);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 16);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ASCII";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.btnClearSend);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(8, 332);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 77);
            this.panel2.TabIndex = 22;
            // 
            // rtbReceive
            // 
            this.rtbReceive.Location = new System.Drawing.Point(211, 32);
            this.rtbReceive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbReceive.Name = "rtbReceive";
            this.rtbReceive.Size = new System.Drawing.Size(325, 246);
            this.rtbReceive.TabIndex = 23;
            this.rtbReceive.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(209, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "接收区";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(546, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "日志";
            // 
            // listSong
            // 
            this.listSong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum,
            this.colName,
            this.colSize,
            this.colStatus});
            this.listSong.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listSong.Location = new System.Drawing.Point(549, 213);
            this.listSong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listSong.Name = "listSong";
            this.listSong.Size = new System.Drawing.Size(233, 159);
            this.listSong.TabIndex = 26;
            this.listSong.UseCompatibleStateImageBehavior = false;
            this.listSong.View = System.Windows.Forms.View.Details;
            // 
            // colNum
            // 
            this.colNum.Tag = "";
            this.colNum.Text = "序号";
            this.colNum.Width = 50;
            // 
            // colName
            // 
            this.colName.Text = "歌曲名";
            this.colName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colName.Width = 116;
            // 
            // colSize
            // 
            this.colSize.Text = "大小";
            this.colSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSize.Width = 95;
            // 
            // colStatus
            // 
            this.colStatus.Text = "状态";
            this.colStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStatus.Width = 72;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 422);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip.Size = new System.Drawing.Size(789, 22);
            this.statusStrip.TabIndex = 27;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(131, 17);
            this.statusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(14, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "接受码";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(15, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "发送码";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 444);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.listSong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbReceive);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbSend);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.OpenFile);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnPlay;
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbReceive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listSong;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colNum;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

