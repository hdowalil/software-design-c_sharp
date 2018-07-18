using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab01.Excercise.Solution.Trainer
{
    internal class AVReceiver : IHDMIConnection
    {
        private readonly IHDMIConnection[] hdmiConnections = new IHDMIConnection[2];
        private Speakers connectedSpeakers = null;
        private bool power = false;
        private int currentSource = 1;

        internal void Power(bool on)
        {
            this.power = on;
        }

        internal void ChangeSource(int slot)
        {
            this.currentSource = slot - 1;
        }

        internal void ConnectSpeakers(Speakers speakers)
        {
            this.connectedSpeakers = speakers;
        }

        internal void PlugIn(int slot, IHDMIConnection input)
        {
            this.hdmiConnections[slot - 1] = input;
        }

        byte[] IHDMIConnection.StreamVideoAndAudio()
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
