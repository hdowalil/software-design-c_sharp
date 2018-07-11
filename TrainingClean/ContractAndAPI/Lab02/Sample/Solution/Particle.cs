using System.Diagnostics.Contracts;

namespace ContractAndAPI.Lab02.Sample.Solution
{
    class Particle
    {
        public double SpeedRelativeToLightSpeed;
        public double massInKilograms;

        public Particle (double speedRelativeToLightSpeed, double massInKilograms)
        {
            this.SpeedRelativeToLightSpeed = speedRelativeToLightSpeed;
            this.massInKilograms = massInKilograms;
        }

        [ContractInvariantMethod]
        protected void ObjectInvariant()
        {
            Contract.Invariant(SpeedRelativeToLightSpeed >= 0);
            Contract.Invariant(SpeedRelativeToLightSpeed < 1.0);  

            // at this moment it is not clear if sthg as a negative mass exists, so we do not check!
        }
        
        // Fancy Physic Logic goes here...

    }
}
