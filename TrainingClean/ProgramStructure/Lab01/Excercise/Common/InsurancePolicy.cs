using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace ProgramStructure.Lab01.Excercise.Common
{
    public class InsurancePolicy
    {
        public string PolicyNr;
        public long Premium = 0;
        private readonly IList<Risk> risks = new List<Risk>();

        public int GetNumberOfRisks()
        {
            return risks.Count;
        }

        public Risk GetRisk(int index)
        {
            return risks[index];
        }

        public void AddRisk(Risk newRisk)
        {
            Contract.Requires(newRisk.Premium > 0);

            risks.Add(newRisk);

            Premium += newRisk.Premium;
        }

    }
}
