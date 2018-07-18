using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab01.Excercise.Solution.Trainer
{
    public class ViewingFacade
    {
        TV tv = null;
        AVReceiver avr = null;
        BluRayPlayer bp = null;
        SatelliteReceiver sat = null;

        public ViewingFacade()
        {
            sat = new SatelliteReceiver();
            sat.Power(true);
            sat.SwitchChannel(3);

            avr = new AVReceiver();
            Speakers speakers = new Speakers();
            avr.Power(true);
            avr.PlugIn(1, sat);
            avr.ConnectSpeakers(speakers);

            tv = new TV();
            tv.PlugIn(avr);

            bp = new BluRayPlayer();
            avr.PlugIn(2, bp);
        }

        public byte[] WatchSatChannel(int channel)
        {
            tv.Power(true);
            avr.Power(true);
            bp.Power(false);
            sat.Power(true);
            avr.ChangeSource(1);
            sat.SwitchChannel(channel);

            return tv.Watch();
        }

        public byte[] WatchBluRay(String disc)
        {

            tv.Power(true);
            avr.Power(true);
            bp.Power(true);
            bp.InsertDisc(disc);
            sat.Power(false);
            avr.ChangeSource(2);

            return tv.Watch();
        }

        public void StopWatching()
        {

            tv.Power(false);
            avr.Power(false);
            bp.Power(false);
            sat.Power(false);
        }

    }
}
