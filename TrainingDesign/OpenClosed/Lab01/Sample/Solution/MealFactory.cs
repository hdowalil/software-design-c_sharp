using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Lab01.Sample.Solution
{
    /// <summary>
    /// GOF: 107
    /// </summary>
    class MealFactory
    {
        protected virtual ISpice ProvideSpice()
        {
            return new Pepper();
        }

        protected virtual IUtensil ProvideUtensil()
        {
            return new FryingPan();
        }

        public Meal prepare()
        {
            IUtensil utensil = ProvideUtensil();
            ISpice spice = ProvideSpice();
            // now do whatever steps are needed to prepare the meal...
            return new Meal();
        }
    }
}
