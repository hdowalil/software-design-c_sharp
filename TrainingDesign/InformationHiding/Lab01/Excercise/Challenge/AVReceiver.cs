using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab01.Excercise.Challenge
{
    public class AVReceiver : IHDMIConnection
    {
        private IHDMIConnection[] hdmiConnections = new IHDMIConnection[2];
        private Speakers connectedSpeakers = null;
        private bool power = false;
        private int currentSource = 1;

        public void Power(bool on)
        {
            this.power = on;
        }

        public void ChangeSource(int slot)
        {
            this.currentSource = slot - 1;
        }

        public void ConnectSpeakers(Speakers speakers)
        {
            this.connectedSpeakers = speakers;
        }

        public void PlugIn(int slot, IHDMIConnection input)
        {
            this.hdmiConnections[slot - 1] = input;
        }

        public byte[] StreamVideoAndAudio()
        {

            IHDMIConnection device = this.hdmiConnections[this.currentSource];
            if (this.power && device != null)
            {

                byte[] result = device.StreamVideoAndAudio();

                if (connectedSpeakers != null)
                {
                    connectedSpeakers.MakeSomeNoise(result);
                }

                return result;

            }
            else
            {

                return new byte[] { };
            }

        }

    }
}
