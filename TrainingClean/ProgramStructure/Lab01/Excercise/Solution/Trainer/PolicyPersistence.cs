using ProgramStructure.Lab01.Excercise.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace ProgramStructure.Lab01.Excercise.Solution.Trainer
{
    public class PolicyPersistence
    {
        public void SavePolicy(InsurancePolicy policy, string file)
        {
            Contract.Requires(policy != null);
            Contract.Requires(file != null);
            Contract.Requires(file.Trim().Length > 0);

            string[] lines = new string[policy.GetNumberOfRisks() + 2];
            lines[0] = policy.PolicyNr;
            lines[1] = policy.Premium.ToString();
            for (int i = 0; i < policy.GetNumberOfRisks(); i++)
            {
                Risk risk = policy.GetRisk(i);
                lines[i + 2] = String.Format("{0},{1},{2}",
                    risk.Premium, risk.InsuredVehicle.RegistrationId, risk.InsuredVehicle.Type);
            }

            System.IO.File.WriteAllLines(file, lines);

        }

        public static void Main(string[] args)
        {

            PolicyPersistence persistence = new PolicyPersistence();
            PolicyLogic logic = new PolicyLogic();

            InsurancePolicy policy = logic.InsureVehicles(
                    new Vehicle("WB-123AB", VehicleType.MotorCycle, 98),
                    new Vehicle("WB-987YZ", VehicleType.Car, 85));

            persistence.SavePolicy(policy, "/Temp/policy2.txt");
        }
    }
}
