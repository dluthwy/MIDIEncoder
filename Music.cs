using System.Collections.Generic;

namespace MidiEncoder {
    class Music {
        //音符列表
        public List<Note> NoteList = new List<Note>();
        //音乐名
        public string MusicName;
        //音乐编号
        public int MusicIndex = 0;
        //音乐大小
        public string MusicSize = "0";
        //文件状态
        public string MusicStatus;
    }
}
