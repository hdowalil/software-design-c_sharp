using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Text;

namespace ProgramStructure.Lab01.Excercise.Common
{
    public class Vehicle
    {
        public string RegistrationId;
        public VehicleType? Type;
        public int HorsePower;

        public Vehicle(string registrationId, VehicleType? type, int horsePower)
        {
            RegistrationId = registrationId;
            Type = type;
            HorsePower = horsePower;
        }

        [ContractInvariantMethod]
        protected void ObjectInvariant()
        {
            Contract.Invariant(RegistrationId != null && RegistrationId.Trim().Length > 0);
            Contract.Invariant(Type != null);
            Contract.Invariant(HorsePower > 0);
        }

    }
}
