using NAudio.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;

namespace MidiEncoder {
    public partial class MainForm : Form
    {
        private List<Note> NoteList = new List<Note>();
        public MainForm(){
            InitializeComponent();
        }
        private List<Note> readMidifile(){
            List<Note> NoteList = new List<Note>();
            int minLength = 9999;
            double initStartTime = 0;

            // 打开文件对话框
            OpenFileDialog newFile = new OpenFileDialog();
            newFile.Filter = "MIDI文件|*.mid";
            newFile.RestoreDirectory = true;
            newFile.FilterIndex = 1;
            if(newFile.ShowDialog() == DialogResult.OK){
                string fNanme = newFile.FileName;
                MidiFile mf = new MidiFile(fNanme);
                List<TempoEvent> tempo = new List<TempoEvent>();

                for (int i = 0; i < mf.Tracks; i++) {
                    foreach (MidiEvent noteEvent in mf.Events[i]) {
                        TempoEvent tempoE;
                        if(noteEvent is TempoEvent) { 
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
                            NoteList.Add(note);
                            if(note.NoteLength < minLength) {
                                minLength = note.NoteLength;
                            }
                        }
                    }
                }
            }
            // 归一化长度
            foreach (Note note in NoteList) {
                note.NoteLength = (int)(note.NoteLength / minLength);
            }
            return NoteList;
        }

        private string ToMBT(long eventTime, int ticksPerQuarterNote, TimeSignatureEvent timeSignature) {
            int beatsPerBar = timeSignature == null ? 4 : timeSignature.Numerator;
            int ticksPerBar = timeSignature == null ? ticksPerQuarterNote * 4 : (timeSignature.Numerator * ticksPerQuarterNote * 4) / (1 << timeSignature.Denominator);
            int ticksPerBeat = ticksPerBar / beatsPerBar;
            long bar = 1 + (eventTime / ticksPerBar);
            long beat = 1 + ((eventTime % ticksPerBar) / ticksPerBeat);
            long tick = eventTime % ticksPerBeat;
            return String.Format("{0}:{1}:{2}", bar, beat, tick);
        }

        private void OpenFile_Click(object sender, EventArgs e){
            this.NoteList = readMidifile();
            NoteFrequencyList nfList = new NoteFrequencyList();
            foreach(Note note in NoteList) {
                double Frequency = nfList.getNoteFrequency(note.NoteNumber);
                string display = String.Format("Track:{0}, Frequency:{1}, StartTime:{2}, Length:{3}, Velocity:{4}\n", note.NoteTrack.ToString(), Frequency.ToString(), note.StartTime.ToString(), note.NoteLength.ToString(), note.NoteVelocity.ToString());
                //int Duration = note.NoteLength * 8;
                //Console.Beep((int)Frequency, Duration);
                rtbLog.AppendText(display);
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e) {
            NoteFrequencyList nfList = new NoteFrequencyList();
            foreach (Note note in NoteList) {
                double Frequency = nfList.getNoteFrequency(note.NoteNumber);
                int Duration = note.NoteLength * 200;
                Console.Beep((int)Frequency, Duration);
            }
            //for (int i = 0; i < NoteList.Count(); i++) {
            //    if (i > 0 && NoteList[i].StartTime != NoteList[i - 1].StartTime) {
            //        double Frequency = nfList.getNoteFrequency(NoteList[i].NoteNumber);
            //        int Duration = NoteList[i].NoteLength * 8;
            //        Console.Beep((int)Frequency, Duration);
            //    }
            //}
        }

        //检测串口
        private void checkSerialPort() {
            try {
                cbxSerialName.Items.Clear();
                string[] str = SerialPort.GetPortNames();
                for (int i = 0; i < str.Length;i++) {
                    cbxSerialName.Items.Add(str[i]);
                }
                cbxSerialName.SelectedIndex = 0;
                statusLabel1.Text = "获取串口信息成功";
            } catch (Exception) {
                statusLabel1.Text = "无法获取可用串口信息";
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            checkSerialPort();
        }
    }
}
