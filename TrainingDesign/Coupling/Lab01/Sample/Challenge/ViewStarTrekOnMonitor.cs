using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Sample.Challenge
{
    class ViewStarTrekOnMonitor
    {
        static void Main(string[] args)
        {
            PersonalComputer pc = new PersonalComputer();
            Monitor monitor = new Monitor();
            monitor.PlugIn(pc);
            pc.Vlc(NetworkAttachedStorage.StarTrek);
            monitor.Display();
            Console.ReadKey();
        }
    }
}
