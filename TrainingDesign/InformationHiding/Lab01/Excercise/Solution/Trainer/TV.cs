using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab01.Excercise.Solution.Trainer
{
    /// <summary>
    /// With only 1 HDMI Input Connection!
    /// </summary>
    internal class TV
    {
        private IHDMIConnection connectedDevice = null;
        private bool power = false;

        internal void Power(bool on)
        {
            this.power = on;
        }

        internal void PlugIn(IHDMIConnection input)
        {
            this.connectedDevice = input;
        }

        internal byte[] Watch()
        {

            if (this.power && connectedDevice != null)
            {

                return connectedDevice.StreamVideoAndAudio();

            }
            else
            {

                return new byte[] { };
            }
        }
    }
}
