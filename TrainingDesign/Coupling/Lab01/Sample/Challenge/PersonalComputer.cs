using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Sample.Challenge
{
    class PersonalComputer : IDVIConnection
    {
        private byte[] picture2Stream = new byte[] { };

        public void Vlc(VideoAndAudio illegallyDownloadedMovie)
        {

            picture2Stream = illegallyDownloadedMovie.Video;

            Console.WriteLine("Audio on PC Speakers: {0}", VideoAndAudio.ConvertByteArrayToString(illegallyDownloadedMovie.Audio));
        }

        public byte[] TransmitVideo()
        {
            return picture2Stream;
        }
    }
}
