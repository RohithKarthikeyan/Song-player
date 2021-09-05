using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace SongPlayer
{
    class Note
    {
        // Define common note frequencies
        public static int NOTE_C = 524;
        public static int NOTE_D = 594;
        public static int NOTE_E = 660;
        public static int NOTE_F = 698;
        public static int NOTE_G = 784;
        public static int NOTE_A = 880;
        public static int NOTE_B = 988;

        // Define common note durations (in milliseconds)
        public static int DURATION_WHOLE = 1600;
        public static int DURATION_HALF = 800;
        public static int DURATION_QUARTER = 400;    

        // Declare the properties for this note
        public int Frequency;
        public int Duration;

        public Note(int frequency, int duration)
        {
            Frequency = frequency;
            Duration = duration;
        }
    }

    class Song
    {
        public string Name;
        public LinkedList<Note> notes;

        public Song(string SongTitle)
        {
            Name = SongTitle;
            notes = new LinkedList<Note>();
        }

        public void AddNote(int frequency, int duration)
        {
            Note beep = new Note(frequency,duration);
            notes.AddLast(beep);
        }

        public void Play()
        {
            LinkedListNode<Note> noteplayer = notes.First;   
            while (noteplayer != null)                       
            {
                Console.Beep(noteplayer.Value.Frequency, noteplayer.Value.Duration);
                noteplayer = noteplayer.Next;                      
            }
        }
    }

}
