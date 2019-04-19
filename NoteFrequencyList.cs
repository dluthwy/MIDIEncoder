﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidiEncoder {
    class NoteFrequencyList {

        private Dictionary<int, double> NoteFrequency = new Dictionary<int, double> {
            {21,27.5},
            {22,29.135},
            {23,30.868},
            {24,32.703},
            {25,34.648},
            {26,36.708},
            {27,38.891},
            {28,41.203},
            {29,43.654},
            {30,46.249},
            {31,48.999},
            {32,51.913},
            {33,55},
            {34,58.27},
            {35,61.735},
            {36,65.406},
            {37,69.296},
            {38,73.416},
            {39,77.782},
            {40,82.407},
            {41,87.307},
            {42,92.449},
            {43,97.999},
            {44,103.83},
            {45,110},
            {46,116.54},
            {47,123.47},
            {48,130.81},
            {49,138.59},
            {50,146.83},
            {51,155.56},
            {52,164.81},
            {53,174.61},
            {54,185},
            {55,196},
            {56,207.65},
            {57,220},
            {58,233.08},
            {59,246.94},
            {60,261.63},
            {61,277.18},
            {62,293.67},
            {63,311.13},
            {64,329.63},
            {65,349.23},
            {66,369.99},
            {67,392},
            {68,415.3},
            {69,444},
            {70,466.16},
            {71,493.88},
            {72,523.25},
            {73,554.37},
            {74,587.33},
            {75,622.25},
            {76,659.26},
            {77,698.46},
            {78,739.99},
            {79,783.99},
            {80,830.61},
            {81,880},
            {82,932.33},
            {83,987.77},
            {84,1046.5},
            {85,1108.7},
            {86,1174.7},
            {87,1244.5},
            {88,1318.5},
            {89,1396.9},
            {90,1480},
            {91,1568},
            {92,1661.2},
            {93,1760},
            {94,1864.7},
            {95,1975.5},
            {96,2093},
            {97,2217.5},
            {98,2349.3},
            {99,2489},
            {100,2637},
            {101,2793},
            {102,2960},
            {103,3136},
            {104,3322.4},
            {105,3520},
            {106,3729.3},
            {107,3951.1},
            {108,4186}
        };

        public double getNoteFrequency(int NoteNumber) {
            double Frequency = 0;
            if (NoteFrequency.TryGetValue(NoteNumber, out Frequency)) {
                return NoteFrequency[NoteNumber];
            }
            return Frequency;
        }
    }
}
