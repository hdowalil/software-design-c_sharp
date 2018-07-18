using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab01.Excercise.Challenge
{
    public class SatelliteReceiver : IHDMIConnection
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

        public SatelliteReceiver()
        {
            channels = new List<byte[]>();

            channels.Add(Encoding.ASCII.GetBytes(ProgramChannel1));
            channels.Add(Encoding.ASCII.GetBytes(ProgramChannel2));
            channels.Add(Encoding.ASCII.GetBytes(ProgramChannel3));
            channels.Add(Encoding.ASCII.GetBytes(ProgramChannel4));
        }

        public void Power(bool on)
        {
            this.power = on;
        }

        public void SwitchChannel(int channel)
        {
            this.channel = channel;
        }

        public byte[] StreamVideoAndAudio()
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
