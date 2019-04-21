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
        //持续周期
        public int Duration;

        public Note(){
            this.NoteName = "unknow";
            this.NoteLength = 0;
            this.NoteVelocity = 0;
            this.NoteNumber = 0;
        }

    }
}
