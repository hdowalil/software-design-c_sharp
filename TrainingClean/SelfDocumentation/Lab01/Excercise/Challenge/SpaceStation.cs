using System;
using System.Collections.Generic;
using System.Text;

namespace SelfDocumentation.Lab01.Excercise.Challenge
{
    public class SpaceStation {

        public readonly IList<StructuralElement> Elements = new List<StructuralElement>();
        public long Oxygen { get; set; } = 10000L;
        public double Battery { get; set; } = 10000d;

        public void logStatus()
        {
            Console.WriteLine("Number of Elements: " + Elements.Count.ToString() +
                " / Oxygen: " + Oxygen.ToString() +
                " / Battery: " + Battery.ToString());
        }

        /// <summary>
        /// Will check for troubles on board the space-station
        /// </summary>
        /// <returns>Will return 0 if everything is fine, 
        /// 1 if there is some problem and 2 if there is a serious problem</returns>
        public int check4Problem()
        {

            // first we check for problems level 2 (= highest severity)
            foreach (StructuralElement element in Elements)
            {
                if (element.StructuralIntegrity < 10)
                {
                    return 2;
                }
                else if (element.Temperature > 50)
                {
                    return 2;
                }
            }

            if (Oxygen < 100L)
            {
                return 2;
            }

            if (Battery < 100d)
            {
                return 2;
            }

            // now check if we have a level 1 problem
            foreach (StructuralElement element in Elements)
            {
                if (element.StructuralIntegrity < 25)
                {
                    return 1;
                }
                else if (element.Temperature > 70)
                {
                    return 1;
                }
            }

            if (Oxygen < 1000L)
            {
                return 1;
            }

            if (Battery < 1000d)
            {
                return 1;
            }

            // everything is fine:
            return 0;
        }


    }



}

