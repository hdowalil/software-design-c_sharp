using ProgramStructure.Lab01.Excercise.Common;
using System;
using System.Diagnostics.Contracts;
using System.Text;

namespace ProgramStructure.Lab01.Excercise.Solution.Trainer
{
    public class PolicyLogic
    {
        // In this class it was decided, that we do not use constants for many values,
        // as their meaning should become clear from the context of their usage.
        // This is especially about horse power limits and premium factors

        private const long BasicPremium = 100L;

        public InsurancePolicy InsureVehicles(params Vehicle[] vehicles)
        {

            InsurancePolicy policy = new InsurancePolicy();
            policy.PolicyNr = GeneratePolicyNr();

            foreach (Vehicle vehicle in vehicles)
            {
                policy.AddRisk(CreateVehicleRisk(vehicle));
            }
 
            return policy;
        }

        private long CalculateMotorcyclePremium(int horsePower)
        {

            long result = BasicPremium;

            if (horsePower > 120)
            {
                throw new ArgumentException("Motorcycles above 120 horsepower cannot be insured");
            }
            if (horsePower > 20)
            {
                result = result * 2;
            }
            if (horsePower > 60)
            {
                result = result * 2;
            }

            return result;
        }

        private long CalculateCarPremium(int horsePower)
        {

            long result = BasicPremium * 4;
            if (horsePower > 100)
            {
                result = result * 2;
            }
            return result;
        }

        private long CalculateTruckPremium(int horsePower)
        {
            return BasicPremium * 10;
        }

        private Risk CreateVehicleRisk(Vehicle input)
        {
            Contract.Requires(input != null);

            Risk newRisk = new Risk();
            newRisk.InsuredVehicle = input;

            switch (input.Type)
            {
                case VehicleType.MotorCycle:
                    newRisk.Premium = CalculateMotorcyclePremium(input.HorsePower);
                    break;
                case VehicleType.Car:
                    newRisk.Premium = CalculateCarPremium(input.HorsePower);
                    break;
                case VehicleType.Truck:
                    newRisk.Premium = CalculateTruckPremium(input.HorsePower);
                    break;
                default:
                    throw new ArgumentException(input.Type.ToString());
            }

            return newRisk;
        }

        private string GeneratePolicyNr()
        {
            return Guid.NewGuid().ToString();
        }

    }
}
