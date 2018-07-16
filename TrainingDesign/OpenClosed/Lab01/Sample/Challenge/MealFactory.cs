using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Lab01.Sample.Challenge
{
    class MealFactory
    {
        public Meal prepare()
        {
            FryingPan utensil = new FryingPan();
            Pepper spice = new Pepper();
            // now do whatever steps are needed to prepare the meal...
            return new Meal();
        }
    }
}
