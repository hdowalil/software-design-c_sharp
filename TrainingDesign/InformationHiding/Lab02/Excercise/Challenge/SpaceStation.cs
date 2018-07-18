using InformationHiding.Lab02.Excercise.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab02.Excercise.Challenge
{
    class SpaceStation : ISpaceLaboratory
    {
        public Battery Battery { get; set; }
        public IList<SolarPanel> SolarPanels { get; set; }

    }
}
