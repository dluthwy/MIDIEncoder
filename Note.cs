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
            double D_s = 1 / this.NoteFrequency / 2;
            int countNum = (int)(65536 - (1e6) * D_s / T_us);
            return countNum;
        }

        //获取长度计数初值
        public int getLengthCN() {
            double T_s = 1 / this.NoteFrequency / 2;
            double D_ms = 7 * this.NoteLength;
            int countNum = (int)(1e-3 * D_ms / T_s );
            return countNum;
        }
    }
}
