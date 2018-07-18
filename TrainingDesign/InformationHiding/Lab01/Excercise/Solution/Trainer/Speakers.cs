using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab01.Excercise.Solution.Trainer
{
    internal class Speakers
    {
        internal void MakeSomeNoise(byte[] audio)
        {
            string outputAudio = Encoding.Default.GetString(audio);
            Console.WriteLine("Audio Output: " + outputAudio);
        }
    }
}
