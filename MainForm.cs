using NAudio.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using System.Drawing;

namespace MidiEncoder {
    public partial class MainForm : Form
    {
        //音乐列表
        private List<Music> MusicList = new List<Music>();
        //串口
        private SerialPort comm = new SerialPort();
        //接收的字符
        private StringBuilder recBuilder = new StringBuilder();
        //发送的字符
        private StringBuilder sendBuilder = new StringBuilder();
        //ASCII码接收
        private bool isRecAsciiMode = false;
        //ACSII码发送
        private bool isSendAsciiMode = false;


        public MainForm(){
            InitializeComponent();
        }
        private List<Music> readMidifile(){
            //音乐列表
            List<Music> MusicList = new List<Music>();
            // 打开文件对话框
            OpenFileDialog newFile = new OpenFileDialog();
            //将音符转换为频率信息
            NoteFrequencyList nfList = new NoteFrequencyList();
            newFile.Filter = "MIDI文件|*.mid";
            newFile.RestoreDirectory = true;
            newFile.FilterIndex = 1;
            newFile.Multiselect = true;
            if(newFile.ShowDialog() == DialogResult.OK){
                string[] fNanmes = newFile.FileNames;
                int musicIndex = 0;
                for(int fileIndex = 0;fileIndex < fNanmes.Count(); fileIndex++) {
                    try {
                        // 打开文件
                        MidiFile mf = new MidiFile(fNanmes[fileIndex]);
                        //创建音乐文件
                        Music music = new Music();
                        music.MusicName = System.IO.Path.GetFileName(fNanmes[fileIndex]);
                        music.MusicIndex = musicIndex ++;
                        //音符列表
                        List<Note> NoteList = new List<Note>();
                        // 最短的音符长度
                        int minLength = 9999;
                        // 音频开始时间
                        double initStartTime = 0;
                        List<TempoEvent> tempo = new List<TempoEvent>();
                        for (int i = 0; i < mf.Tracks; i++) {
                            foreach (MidiEvent noteEvent in mf.Events[i]) {
                                TempoEvent tempoE;
                                if (noteEvent is TempoEvent) {
                                    tempoE = (TempoEvent)noteEvent;
                                    tempo.Add(tempoE);
                                }

                                if (noteEvent.CommandCode == MidiCommandCode.NoteOn) {
                                    var t_note = (NoteOnEvent)noteEvent;
                                    var noteOffEvent = t_note.OffEvent;

                                    //生成新 Note
                                    Note note = new Note();
                                    note.NoteName = t_note.NoteName;
                                    note.NoteNumber = t_note.NoteNumber;
                                    note.NoteFrequency = nfList.getNoteFrequency(note.NoteNumber);
                                    note.NoteVelocity = t_note.Velocity;
                                    note.NoteLength = t_note.NoteLength;
                                    note.NoteTrack = i;
                                    note.NoteChannel = t_note.Channel;
                                    //开始时间归零
                                    if (NoteList.Count > 0) {
                                        note.StartTime = (t_note.AbsoluteTime / mf.DeltaTicksPerQuarterNote) * tempo[tempo.Count() - 1].Tempo - initStartTime;
                                    } else {
                                        initStartTime = (t_note.AbsoluteTime / mf.DeltaTicksPerQuarterNote) * tempo[tempo.Count() - 1].Tempo;
                                        note.StartTime = 0;
                                    }
                                    //将note加入NoteList中
                                    NoteList.Add(note);
                                    if (note.NoteLength < minLength) {
                                        minLength = note.NoteLength;
                                    }
                                }
                            }
                            // 归一化长度
                            //foreach (Note note in NoteList) {
                            //    note.NoteLength = (int)(note.NoteLength / minLength);
                            //}
                        }
                        music.NoteList = NoteList;
                        music.MusicSize = NoteList.Count().ToString();
                        music.MusicStatus = "已解码";
                        //获取乐谱信息
                        double totalInterval = 0;
                        int totalLength = 0;
                        int count = 0;
                        for(int i = 0;i < NoteList.Count() - 1;i++) {
                            if(NoteList[i + 1].StartTime != NoteList[i].StartTime) {
                                totalInterval += NoteList[i + 1].StartTime - NoteList[i].StartTime;
                                count++;
                            }
                            totalLength += NoteList[i].NoteLength;
                        }
                        music.AveInterval = totalInterval / count;
                        music.AveNoteLength = totalLength / NoteList.Count();
                        //加入音乐列表
                        MusicList.Add(music);
                        rtbLog.AppendText(music.MusicName + "解码成功!\n");
                    } catch {
                        rtbLog.AppendText(System.IO.Path.GetFileName(fNanmes[fileIndex]) + "文件打开失败\n");
                        continue;
                    }
                }
                
            }
            return MusicList;
        }

        //改变接收模式
        private void changedRecMode() {
            if (this.rabRecAscii.Checked) {
                this.isRecAsciiMode = true;
            } else if (rabRecHex.Checked) {
                this.isRecAsciiMode = false;
            }
        }

        //改变发送模式
        private void changedSendMode() {
            if (this.rabRecAscii.Checked) {
                this.isSendAsciiMode = true;
            }else if (this.rabSendHex.Checked) {
                this.isSendAsciiMode = false;
            }
        }

        //更新显示MusicListView
        private void UpdateMusicListView(List<Music> MusicList) {
            //清除列表
            this.listMusicView.Items.Clear();
            //开始更新
            this.listMusicView.BeginUpdate();
            foreach(Music music in MusicList) {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = music.MusicIndex.ToString();
                lvi.SubItems.Add(music.MusicName);
                lvi.SubItems.Add(music.MusicSize);
                lvi.SubItems.Add(music.MusicStatus);
                this.listMusicView.Items.Add(lvi);
            }
            //停止更新
            this.listMusicView.EndUpdate();
        }

        //加载文件
        private void OpenFile_Click(object sender, EventArgs e){
            this.MusicList = readMidifile();
            UpdateMusicListView(MusicList);
        }

        //检测串口
        private void checkSerialPort() {
            try {
                cbxSerialName.Items.Clear();
                string[] ports = SerialPort.GetPortNames();
                Array.Sort(ports);
                cbxSerialName.Items.AddRange(ports);
                cbxSerialName.SelectedIndex = cbxSerialName.Items.Count > 0 ? 0 : -1;
                //串口默认设置
                cbxBaud.SelectedIndex = cbxBaud.Items.IndexOf("9600");
                cbxCheckBit.SelectedIndex = cbxCheckBit.Items.IndexOf("None"); 
                cbxStopBit.SelectedIndex = cbxStopBit.Items.IndexOf("1");
                cbxDataBit.SelectedIndex = cbxDataBit.Items.IndexOf("8");
                //设置串口参数
                comm.NewLine = "\r\n";
                comm.RtsEnable = true;
                //注册对串口接收数据的响应方法
                comm.DataReceived += new SerialDataReceivedEventHandler(commDataReceived);
                statusLabel1.Text = "获取串口信息成功";
            } catch (Exception) {
                statusLabel1.Text = "无法获取可用串口信息";
            }
        }

        //窗口加载
        private void MainForm_Load(object sender, EventArgs e) {
            checkSerialPort();
        }

        //打开串口
        private void BtnSerialPort_Click(object sender, EventArgs e) {
            //如果打开则关闭
            if (this.comm.IsOpen) {
                this.comm.Close();
                this.btnSerialPort.BackColor = Color.Green;
            } else {
                if(cbxSerialName.Text != "") {
                    //串口名
                    comm.PortName = this.cbxSerialName.Text;
                } else {
                    statusLabel1.Text = "串口为空";
                    return;
                }
                //串口波特率
                comm.BaudRate = int.Parse(this.cbxBaud.Text);
                //奇偶校验位
                if(cbxCheckBit.Text == "Odd") {
                    comm.Parity = Parity.Odd;
                }else if(cbxCheckBit.Text == "Even") {
                    comm.Parity = Parity.Even;
                } else {
                    comm.Parity = Parity.None;
                }
                //串口数据位
                comm.DataBits = int.Parse(this.cbxDataBit.Text);
                //串口停止位
                if(cbxStopBit.Text == "None") {
                    comm.StopBits = StopBits.None;
                }else if(cbxStopBit.Text == "1") {
                    comm.StopBits = StopBits.One;
                }else if(cbxStopBit.Text == "1.5") {
                    comm.StopBits = StopBits.OnePointFive;
                } else {
                    comm.StopBits = StopBits.Two;
                }
                //串口读取缓冲区大小
                comm.ReadBufferSize = 1024;
                //串口发送缓冲区大小
                comm.WriteBufferSize = 4096;
                
                try {
                    if(!comm.IsOpen) {
                        this.comm.Open();
                        this.btnSerialPort.BackColor = Color.Red;
                    }
                } catch(Exception ex) {
                    comm = new SerialPort();
                    MessageBox.Show(ex.Message);
                }
            }

            this.btnSerialPort.Text = comm.IsOpen ? "关闭串口" : "打开串口";

            this.btnSend.Enabled = comm.IsOpen;

        }

        //串口发送
        private void BtnSend_Click(object sender, EventArgs e) {
            //foreach(Music music in MusicList) {
            //    foreach(Note note in music.NoteList) {
            //        if(note.NoteLength != 0) {
            //            int Frequency = (int)note.NoteFrequency;
            //            double Duration = music.AveInterval / music.AveNoteLength * 4 * note.NoteLength;
            //            Console.Beep(Frequency, (int)Math.Ceiling(Duration));
            //        }
            //    }
            //}
            sendMusicNotes(3);
        }

        //串口接收
        void commDataReceived(object sender, SerialDataReceivedEventArgs e) {
            //获取接收缓冲区中数据的字节数
            int n = comm.BytesToRead;
            byte[] buf = new byte[n];

            //将数据读入buf数组中
            comm.Read(buf, 0, n);

            //处理单片机请求
            foreach(byte command in buf) {
                handleMcsRequests(command);
            }
            //先清空
            recBuilder.Clear();

            //因为要访问ui资源，所以需要使用invoke方式同步ui
            this.Invoke((EventHandler)(delegate {
                //委托方法在rtbReceive控件中显示接收到的字符
                if (isRecAsciiMode) {
                    recBuilder.Append(Encoding.ASCII.GetString(buf));
                } else {
                    recBuilder.Append(byteToHexStr(buf));
                }
                
                this.rtbReceive.AppendText(recBuilder.ToString());
            }));
        }

        //发送乐谱信息
        void sendMusicNotes(int musicIndex) {
            try {
                //清空发送缓冲区
                comm.DiscardOutBuffer();
                //清空发送Builder
                sendBuilder.Clear();
                if (musicIndex > MusicList.Count()) {
                    this.Invoke((EventHandler)(delegate {
                        rtbLog.AppendText("串口发送失败！\n索引超出长度\n");
                    }));
                    return;
                }
                this.Invoke((EventHandler)(delegate {
                    rtbLog.AppendText("客户端请求 " + MusicList[musicIndex - 1].MusicName + " 音乐信息\n");
                }));
                foreach (Note note in MusicList[musicIndex - 1].NoteList) {
                    //获取计数值转换为bytes发送
                    int NoteFrequencyCN = note.getFrequencyCN();
                    int NoteLengthCN = note.getLengthCN();
                    byte[] NoteFrequencyBytes = BitConverter.GetBytes(NoteFrequencyCN).Skip(0).Take(2).ToArray();
                    byte[] NoteLengthBytes = BitConverter.GetBytes(NoteLengthCN).Skip(0).Take(2).ToArray();
                    //将音符的频率计数初值和长度控制计数初值写入串口发送缓冲区
                    comm.Write(NoteFrequencyBytes, 0, 2);
                    comm.Write(NoteLengthBytes, 0, 2);
                    //判断发送模式
                    if (isSendAsciiMode) {
                        sendBuilder.Append(Encoding.ASCII.GetString(NoteFrequencyBytes));
                        sendBuilder.Append(Encoding.ASCII.GetString(NoteLengthBytes));
                    } else {
                        sendBuilder.Append(byteToHexStr(NoteFrequencyBytes));
                        sendBuilder.Append(byteToHexStr(NoteLengthBytes));
                    }
                }
                //更新UI显示
                //因为要访问ui资源，所以需要使用invoke方式同步ui
                this.Invoke((EventHandler)(delegate {
                    //委托方法在rtbSend控件中显示发送的字符
                    this.rtbSend.AppendText(sendBuilder.ToString());
                    rtbLog.AppendText("发送 " + MusicList[musicIndex - 1].MusicName + " 乐谱成功\n");
                }));
            } catch(Exception ex) {
                this.Invoke((EventHandler)(delegate {
                    rtbLog.AppendText("串口发送失败！\n" + ex.ToString());
                }));
            }
        }

        //发送音乐列表
        void sendMusicList() {
            try {
                //清空发送缓冲区
                comm.DiscardOutBuffer();
                //清空发送Builder
                sendBuilder.Clear();
                //先写入歌曲的数量，最大为8首，1字节数据
                int MusicNum = Math.Min(MusicList.Count(), 8);
                byte[] MusicNumBytes = BitConverter.GetBytes(MusicNum).Skip(0).Take(1).ToArray();
                //以一个byte发送歌曲数量
                comm.Write(MusicNumBytes, 0, 1);
                //判断发送模式
                if (isSendAsciiMode) {
                    sendBuilder.Append(Encoding.ASCII.GetString(MusicNumBytes));
                } else {
                    sendBuilder.Append(byteToHexStr(MusicNumBytes));
                }
                //写入MusicNum首歌曲名称信息
                for (int i = 0; i < MusicNum; i++) {
                    string MusicName = MusicList[i].MusicName.Split('.')[0];
                    byte[] MusicNameBytes = Encoding.Unicode.GetBytes(MusicName);
                    //已两字节的Unicode编码发送歌曲名
                    comm.Write(MusicNameBytes, 0, MusicNameBytes.Length);
                    //判断发送模式
                    if (isSendAsciiMode) {
                        sendBuilder.Append(Encoding.Unicode.GetString(MusicNameBytes));
                    } else {
                        sendBuilder.Append(byteToHexStr(MusicNameBytes));
                    }
                }
                //更新UI显示
                //因为要访问ui资源，所以需要使用invoke方式同步ui
                //委托方法在rtbSend控件中显示发送的字符
                this.Invoke((EventHandler)(delegate {
                    rtbSend.AppendText(sendBuilder.ToString());
                    rtbLog.AppendText("音乐列表已写入串口发送缓冲区，共" + MusicNum.ToString() + "首\n");
                }));
            }catch(Exception ex) {
                this.Invoke((EventHandler)(delegate {
                    rtbLog.AppendText("串口发送失败！\n" + ex.ToString());
                }));
            }
        }

        //处理单片机请求事件
        void handleMcsRequests(byte command) {
            if(command == 0x00) {
                //刷新列表
                this.Invoke((EventHandler)(delegate {
                    rtbLog.AppendText("客户端请求音乐列表\n");
                }));
                sendMusicList();
            } else if (command >= 0x01 && command <= 0x08) {
                byte[] byteArray = new byte[4];
                byteArray[0] = command;
                //播放对应歌曲
                int musicIndex = System.BitConverter.ToInt32(byteArray, 0);
                //发送第musicIndex号音符列表
                sendMusicNotes(musicIndex);
            }
        }

        //字节数组转16进制字符串
        public static string byteToHexStr(byte[] bytes) {
            string returnStr = "";
            if (bytes != null) {
                for (int i = 0; i < bytes.Length; i++) {
                    returnStr += bytes[i].ToString("X2") + " ";
                }
            }
            return returnStr;
        }

        //清空接收
        private void BtnClearRec_Click(object sender, EventArgs e) {
            rtbReceive.Text = "";
        }

        //清空发送
        private void BtnClearSend_Click(object sender, EventArgs e) {
            rtbSend.Text = "";
        }

        private void RabRecAscii_CheckedChanged(object sender, EventArgs e) {
            changedRecMode();
        }

        private void RabRecHex_CheckedChanged(object sender, EventArgs e) {
            changedRecMode();
        }

        private void RabSendAscii_CheckedChanged(object sender, EventArgs e) {
            changedSendMode();
        }

        private void RabSendHex_CheckedChanged(object sender, EventArgs e) {
            changedSendMode();
        }
    }
}
