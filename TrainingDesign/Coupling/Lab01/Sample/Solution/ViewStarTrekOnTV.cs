using Coupling.Lab01.Sample.Challenge;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Sample.Solution
{
    class ViewStarTrekOnTV
    {
        static void Main(string[] args)
        {
            PersonalComputer pc = new PersonalComputer();
            TV tv = new TV();
            DVIProviderHDMIConsumerAdapter adapter = new DVIProviderHDMIConsumerAdapter(pc);
            tv.PlugIn(adapter);
            tv.Power(true);
            pc.Vlc(NetworkAttachedStorage.StarTrek);
            tv.Watch();
            Console.ReadKey();
        }
    }
}
