using OpenClosed.Lab01.Excercise.Solution.Trainer.Asian;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Lab01.Excercise.Solution.Trainer
{
    class MealFactory
    {

        public Meal Prepare(Func<IUtensil> utensilSupplier, Func<ISpice> spiceSupplier)
        {
            ISpice spice = spiceSupplier.Invoke();
            IUtensil utensil = utensilSupplier.Invoke();

            // now do whatever steps are needed to prepare the meal...

            return new Meal();
        }

        static void Main(string[] args)
        {
            MealFactory factory = new MealFactory();
            Meal westernMeal = factory.Prepare(() => { return new FryingPan(); }, () => { return new Pepper(); });
            Meal asianMeal = factory.Prepare(() => { return new Wok(); }, () => { return new Curry(); });
        }
    }
}
