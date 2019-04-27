using System;

namespace MidiEncoder {
    class Note
    {
        //音符名称
        public string NoteName;
        //音符号
        public int NoteNumber;
        //音符速度或力度
        public int NoteVelocity;
        //音符长度
        public int NoteLength;
        //音道
        public int NoteChannel;
        //音轨
        public int NoteTrack = 0;
        //音符开始时间
        public double StartTime;
        //频率
        public double NoteFrequency;

        public Note(){
            this.NoteName = "unknow";
            this.NoteLength = 0;
            this.NoteVelocity = 0;
            this.NoteNumber = 0;
        }

        //获取频率计数初值
        public int getFrequencyCN() {
            double T_us = 12 / 11.0592;
            int countNum = (int)(65536 - (10 ^ 6) / (2 * this.NoteFrequency * T_us));
            return countNum;
        }

        //获取长度计数初值
        public int getLengthCN(Music music) {
            int count = 100;
            double T_us = 12 / 11.0592;
            double D_us = music.AveInterval / music.AveNoteLength * 4 * this.NoteLength * (10^3);
            int countNum = (int)(65536 - D_us / T_us / count);
            return countNum;
        }
    }
}
