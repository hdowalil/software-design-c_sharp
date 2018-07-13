using System;
using System.Text;

namespace Coupling.Lab01.Sample.Challenge
{
    class TV
    {
        private IHDMIConnection connectedDevice = null;
        private bool power = false;

        public void Power(bool on)
        {
            this.power = on;
        }

        public void PlugIn(IHDMIConnection input)
        {
            this.connectedDevice = input;
        }

        public void Watch()
        {
            if (this.power && connectedDevice != null)
            {
                VideoAndAudio receivedBinary = connectedDevice.StreamVideoAndAudio();
                Console.WriteLine("Video on TV: {0}", VideoAndAudio.ConvertByteArrayToString(receivedBinary.Video));
                Console.WriteLine("Audio on TV: {0}", VideoAndAudio.ConvertByteArrayToString(receivedBinary.Audio));
            }
        }

    }
}
