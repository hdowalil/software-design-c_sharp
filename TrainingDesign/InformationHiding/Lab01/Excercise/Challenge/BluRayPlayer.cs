using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab01.Excercise.Challenge
{
    public class BluRayPlayer : IHDMIConnection
    {
        private string disc = null;
        private bool power = false;

        public void Power(bool on)
        {
            this.power = on;
        }

        public void InsertDisc(string disc)
        {
            this.disc = disc;
        }

        public byte[] StreamVideoAndAudio()
        {
            if (power && disc != null)
            {
                return Encoding.ASCII.GetBytes(disc);
            }
            else
            {
                return new byte[] { };
            }
        }

    }
}
