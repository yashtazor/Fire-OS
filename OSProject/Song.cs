using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Input;
using Sys = Cosmos.System;
using System.Threading;
using Cosmos.Core.IOGroup;

namespace OSProject
{
    public class Song
    {
        public static void main()
        {
            Note[] Mary =
            {
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.GbelowC, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.B, Duration.HALF),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.A, Duration.HALF),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.D, Duration.QUARTER),
                new Note(Tone.D, Duration.HALF)
            };

            Play(Mary);
            return;
        }

        // Play the notes in a song.
        public static void Play(Note[] tune)
        {
            foreach (Note n in tune)
            {
                if (n.NoteTone == Tone.REST)
                {
                    Thread.Sleep((int)n.NoteDuration);
                }
                else
                {
                    Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
                }
            }
        }

        // Define the frequencies of notes in an octave, as well as 
        // silence (rest).
        public enum Tone
        {
            REST = 0,
            GbelowC = 196,
            A = 220,
            Asharp = 233,
            B = 247,
            C = 262,
            Csharp = 277,
            D = 294,
            Dsharp = 311,
            E = 330,
            F = 349,
            Fsharp = 370,
            G = 392,
            Gsharp = 415,
        }

        // Define the duration of a note in units of milliseconds.
        public enum Duration
        {
            WHOLE = 1600,
            HALF = WHOLE / 2,
            QUARTER = HALF / 2,
            EIGHTH = QUARTER / 2,
            SIXTEENTH = EIGHTH / 2,
        }

        // Define a note as a frequency (tone) and the amount of 
        // time (duration) the note plays.
        public struct Note
        {
            Tone toneVal;
            Duration durVal;

            // Define a constructor to create a specific note.
            public Note(Tone frequency, Duration time)
            {
                toneVal = frequency;
                durVal = time;
            }

            // Define properties to return the note's tone and duration.
            public Tone NoteTone { get { return toneVal; } }
            public Duration NoteDuration { get { return durVal; } }
        }
    }

    /*public class Song // Jana's test. Improvise if needed.
    {
        public static void main()
        {
            Console.WriteLine("Welcome to Symphony Piano");
            int[] PKeys =
            {
                290,300,330,345,360,390,405,440,460,480,505,530,580,605,630,670,700
            };

            Play(PKeys);
            Console.Clear();
            return;
        }

        // Play the notes in a song.
        public static void Play(int[] PNotes)
        {
            Console.WriteLine("Following are the key strokes for various frequencies");
            Console.WriteLine("   |300|345| |405|460|505| |605|670|");
            Console.WriteLine("   | 2 | 3 | | 5 | 6 | 7 | | 9 | 0 |");
            Console.WriteLine("|290|330|360|390|440|480|530|580|630|700|");
            Console.WriteLine("| Q | W | E | R | T | Y | U | I | O | P |");
            Console.WriteLine("Press X to quit");
            string play = "yes";
            while(play == "yes")
            {
                while (Console.KeyAvailable == false)
                    Thread.Sleep(250);
                if (Console.ReadKey().Key==ConsoleKey.Q)
                {
                    Console.Beep(PNotes[0], 1000);
                }
                if(Console.ReadKey().Key==ConsoleKey.D2)
                {
                    Console.Beep(PNotes[1], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.W)
                {
                    Console.Beep(PNotes[2], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.D3)
                {
                    Console.Beep(PNotes[3], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.E)
                {
                    Console.Beep(PNotes[4], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.Beep(PNotes[5], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.D5)
                {
                    Console.Beep(PNotes[6], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.T)
                {
                    Console.Beep(PNotes[7], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.D6)
                {
                    Console.Beep(PNotes[8], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Beep(PNotes[9], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.D7)
                {
                    Console.Beep(PNotes[10], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.U)
                {
                    Console.Beep(PNotes[11], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.I)
                {
                    Console.Beep(PNotes[12], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.D9)
                {
                    Console.Beep(PNotes[13], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.O)
                {
                    Console.Beep(PNotes[14], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.D0)
                {
                    Console.Beep(PNotes[15], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.P)
                {
                    Console.Beep(PNotes[16], 1000);
                }
                if (Console.ReadKey().Key == ConsoleKey.X)
                {
                    break;
                }
            }
        }

        // Define the frequencies of notes in an octave, as well as 
        // silence (rest).
        public enum Tone
        {
            REST = 0,
            GbelowC = 196,
            A = 220,
            Asharp = 233,
            B = 247,
            C = 262,
            Csharp = 277,
            D = 294,
            Dsharp = 311,
            E = 330,
            F = 349,
            Fsharp = 370,
            G = 392,
            Gsharp = 415,
        }

        // Define the duration of a note in units of milliseconds.
        public enum Duration
        {
            WHOLE = 1600,
            HALF = WHOLE / 2,
            QUARTER = HALF / 2,
            EIGHTH = QUARTER / 2,
            SIXTEENTH = EIGHTH / 2,
        }

        // Define a note as a frequency (tone) and the amount of 
        // time (duration) the note plays.
        public struct Note
        {
            Tone toneVal;
            Duration durVal;

            // Define a constructor to create a specific note.
            public Note(Tone frequency, Duration time)
            {
                toneVal = frequency;
                durVal = time;
            }

            // Define properties to return the note's tone and duration.
            public Tone NoteTone { get { return toneVal; } }
            public Duration NoteDuration { get { return durVal; } }
        }
    }*/
}
