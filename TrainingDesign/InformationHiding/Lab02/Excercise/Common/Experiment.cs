using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace InformationHiding.Lab02.Excercise.Common
{
    class Experiment
    {
        private int input1;
        private int input2;

        public Experiment(int input1, int input2)
        {
            this.input1 = input1;
            this.input2 = input2;
        }

        public int RunExperiment(ISpaceLaboratory lab, Battery energySource)
        {
            Contract.Requires(lab != null);
            Contract.Requires(energySource != null);

            energySource.Use(2d);
            Random rnd = new Random(input1);
            return rnd.Next(input2);
        }

    }
}
