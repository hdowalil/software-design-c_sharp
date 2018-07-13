using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Sample.Challenge
{
    class VideoAndAudio
    {
        public static readonly byte[] Silence = new byte[] { };

        public readonly byte[] Video;
        public readonly byte[] Audio;

        public VideoAndAudio(byte[] video, byte[] audio)
        {
            Video = video;
            Audio = audio;
        }

        public static string ConvertByteArrayToString(byte[] input)
        {
            return Encoding.Default.GetString(input);
        }

        public static byte[] ConvertStringToByteArray(string input)
        {
            return Encoding.ASCII.GetBytes(input);
        }
    }
}
