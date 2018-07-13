using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Sample.Challenge
{
    class Monitor
    {
        private IDVIConnection connectedDevice = null;

        public void PlugIn(IDVIConnection device)
        {
            connectedDevice = device;
        }

        public void Display()
        {
            if (connectedDevice != null)
            {
                String video = VideoAndAudio.ConvertByteArrayToString(connectedDevice.TransmitVideo());
                Console.WriteLine("Video on Monitor: {0}", video);
            }
        }

    }
}
