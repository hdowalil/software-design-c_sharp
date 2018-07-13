using Coupling.Lab01.Excercise.Challenge.Legacy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Excercise.Solution.Trainer
{
    class RunLegacyUIWithCots
    {
        static void Main(string[] args)
        {
            SearchApiAdapter adapter = new SearchApiAdapter();
            LegacyUserInterface ui = new LegacyUserInterface(adapter);
            ui.RunConsole();
        }
    }
}
