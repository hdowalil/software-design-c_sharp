using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab01.Excercise.Solution.Trainer
{
    internal class BluRayPlayer : IHDMIConnection
    {
        private string disc = null;
        private bool power = false;

        internal void Power(bool on)
        {
            this.power = on;
        }

        internal void InsertDisc(string disc)
        {
            this.disc = disc;
        }

        byte[] IHDMIConnection.StreamVideoAndAudio()
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
