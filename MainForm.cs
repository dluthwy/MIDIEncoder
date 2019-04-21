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
        //接收到的字符
        private StringBuilder Builder = new StringBuilder();
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
                            foreach (Note note in NoteList) {
                                note.NoteLength = (int)(note.NoteLength / minLength);
                            }
                        }
                        music.NoteList = NoteList;
                        music.MusicSize = NoteList.Count().ToString();
                        music.MusicStatus = "已解码";
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
                comm.DataReceived += new SerialDataReceivedEventHandler(comm_DataReceived);
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
                //串口名
                comm.PortName = this.cbxSerialName.Text;
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
                
                try {
                    this.comm.Open();
                    this.btnSerialPort.BackColor = Color.Red;
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
            
        }

        //串口接收
        void comm_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            //获取接收缓冲区中数据的字节数
            int n = comm.BytesToRead;
            byte[] buf = new byte[n];

            //将数据读入buf数组中
            comm.Read(buf, 0, n);

            //先清空
            Builder.Clear();

            //因为要访问ui资源，所以需要使用invoke方式同步ui
            this.Invoke((EventHandler)(delegate {
                //委托方法在rtbReceive控件中显示接收到的字符
                if (isRecAsciiMode) {
                    Builder.Append(Encoding.ASCII.GetString(buf));
                } else {
                    Builder.Append(byteToHexStr(buf));
                }
                
                this.rtbReceive.AppendText(Builder.ToString());
            }));

        }

        //字节数组转16进制字符串
        public static string byteToHexStr(byte[] bytes) {
            string returnStr = "";
            if (bytes != null) {
                for (int i = 0; i < bytes.Length; i++) {
                    returnStr += bytes[i].ToString("X2");
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
