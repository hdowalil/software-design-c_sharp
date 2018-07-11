using System;
using ProgramStructure.Lab01.Excercise.Common;
using System.Collections.Generic;
using System.Text;

namespace ProgramStructure.Lab01.Excercise.Challenge
{
    public class PolicyCreator
    {
        public InsurancePolicy CreateAndSavePolicy(params Vehicle[] vehicles)
        {
            InsurancePolicy policy = new InsurancePolicy();

            foreach (Vehicle vehicle in vehicles)
            {
                Risk newRisk = new Risk();
                newRisk.InsuredVehicle = vehicle;

                // Basic Premium
                newRisk.Premium = 100;

                if (VehicleType.MotorCycle == vehicle.Type)
                {

                    if (vehicle.HorsePower > 120)
                    {
                        throw new ArgumentException("Motorcycles above 120 horsepower cannot be insured");
                    }
                    if (vehicle.HorsePower > 20)
                    {
                        newRisk.Premium = newRisk.Premium * 2;
                    }
                    if (vehicle.HorsePower > 60)
                    {
                        newRisk.Premium = newRisk.Premium * 2;
                    }

                }
                else if (VehicleType.Car == vehicle.Type)
                {

                    newRisk.Premium = newRisk.Premium * 4;
                    if (vehicle.HorsePower > 100)
                    {
                        newRisk.Premium = newRisk.Premium * 2;
                    }

                }
                else if (VehicleType.Car == vehicle.Type)
                {

                    // Flatrate
                    newRisk.Premium = newRisk.Premium * 10;
                }

                policy.AddRisk(newRisk);
            }

            policy.PolicyNr = Guid.NewGuid().ToString();

            string[] lines = new string[policy.GetNumberOfRisks() + 2];
            lines[0] = policy.PolicyNr;
            lines[1] = policy.Premium.ToString();
            for (int i=0; i<policy.GetNumberOfRisks(); i++) {
                Risk risk = policy.GetRisk(i);
                lines[i + 2] = String.Format("{0},{1},{2}", 
                    risk.Premium, risk.InsuredVehicle.RegistrationId, risk.InsuredVehicle.Type);
            }

            System.IO.File.WriteAllLines("/Temp/policy.txt", lines);

            return policy;
        }

        public static void Main(string[] args)
        {
            PolicyCreator creator = new PolicyCreator();

            creator.CreateAndSavePolicy(
                    new Vehicle("WB-123AB", VehicleType.MotorCycle, 98),
                    new Vehicle("WB-987YZ", VehicleType.Car, 85));

        }
    }
}
