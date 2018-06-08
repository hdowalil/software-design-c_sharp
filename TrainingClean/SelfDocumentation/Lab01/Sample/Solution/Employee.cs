using System;
using System.Collections.Generic;
using System.Text;

namespace SelfDocumentation.Lab01.Sample.Solution
{
    class Employee
    {
        private const long BasicSalary = 1000L;
        private const int BonusFactor = 2;

        private const int MinimumPatternKnowhowPercentageOfSenior = 50;
        private const int MinimumYearsExperienceOfSenior = 3;

        public readonly bool RelatedToManager;
        public readonly int PercentagePatternKnowHow;
        public readonly int YearsExperience;
        public readonly bool ExternalEmployee;

        public bool SeniorDeveloper => (PercentagePatternKnowHow >= MinimumPatternKnowhowPercentageOfSenior
                && YearsExperience > MinimumYearsExperienceOfSenior);

        public bool ShouldBecomeABonus => ((SeniorDeveloper && !ExternalEmployee) || RelatedToManager);

        public long Salary => (ShouldBecomeABonus ? BasicSalary * BonusFactor : BasicSalary);

        public Employee(bool relatedToManager, int percentagePatternKnowHow, int yearsExperience, bool externalEmployee)
        {
            RelatedToManager = relatedToManager;
            PercentagePatternKnowHow = percentagePatternKnowHow;
            YearsExperience = yearsExperience;
            ExternalEmployee = externalEmployee;
        }

    }
}
