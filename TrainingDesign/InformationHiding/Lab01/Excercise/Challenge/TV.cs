using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab01.Excercise.Challenge
{
    /// <summary>
    /// With only 1 HDMI Input Connection!
    /// </summary>
    public class TV
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

        public byte[] Watch()
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
