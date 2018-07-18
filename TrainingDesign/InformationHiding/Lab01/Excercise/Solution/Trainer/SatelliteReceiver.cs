using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab01.Excercise.Solution.Trainer
{
    internal class SatelliteReceiver : IHDMIConnection
    {
        private const string ProgramChannel1 =
                "The first Rule of Fight Club is, you do not talk about fight club.";
        private const string ProgramChannel2 =
                "These aren't the droids you're looking for...";
        private const string ProgramChannel3 =
                "You wanna know how I got these scars?";
        private const string ProgramChannel4 =
                "A Royale with cheese. What do they call a Big Mac?";

        private IList<byte[]> channels;
        private bool power = false;
        private int channel = 1;

        internal SatelliteReceiver()
        {
            channels = new List<byte[]>();

            channels.Add(Encoding.ASCII.GetBytes(ProgramChannel1));
            channels.Add(Encoding.ASCII.GetBytes(ProgramChannel2));
            channels.Add(Encoding.ASCII.GetBytes(ProgramChannel3));
            channels.Add(Encoding.ASCII.GetBytes(ProgramChannel4));
        }

        internal void Power(bool on)
        {
            this.power = on;
        }

        internal void SwitchChannel(int channel)
        {
            this.channel = channel;
        }

        byte[] IHDMIConnection.StreamVideoAndAudio()
        {
            if (power)
            {
                return channels[channel - 1];
            }
            else
            {
                return new byte[] { };
            }
        }
    }
}
