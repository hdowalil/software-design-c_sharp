using Coupling.Lab01.Sample.Challenge;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Sample.Solution
{
    class DVIProviderHDMIConsumerAdapter : IHDMIConnection
    {
        private IDVIConnection dviDelegate;

        public DVIProviderHDMIConsumerAdapter(IDVIConnection dviDelegate)
        {
            this.dviDelegate = dviDelegate;
        }

        public VideoAndAudio StreamVideoAndAudio()
        {
            byte[] video = dviDelegate.TransmitVideo();
            VideoAndAudio result = new VideoAndAudio(
                video,
                VideoAndAudio.Silence);
            return result;
        }
    }
}
