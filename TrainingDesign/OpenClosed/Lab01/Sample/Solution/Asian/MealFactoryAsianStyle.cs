using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Lab01.Sample.Solution.Asian
{
    class MealFactoryAsianStyle : MealFactory
    {
        protected override ISpice ProvideSpice()
        {
            return new Curry();
        }

        protected override IUtensil ProvideUtensil()
        {
            return new Wok();
        }

    }
}
