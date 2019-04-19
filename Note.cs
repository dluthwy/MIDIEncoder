using System;

namespace MidiEncoder {
    class Note
    {
        public string NoteName;
        public int NoteNumber;
        public int NoteVelocity;
        public int NoteLength;
        public int NoteChannel;
        public int NoteTrack = 0;
        public double StartTime;
        public int NoteFrequency;
        public int Duration;

        public Note(){
            this.NoteName = "unknow";
            this.NoteLength = 0;
            this.NoteVelocity = 0;
            this.NoteNumber = 0;
        }

    }
}
