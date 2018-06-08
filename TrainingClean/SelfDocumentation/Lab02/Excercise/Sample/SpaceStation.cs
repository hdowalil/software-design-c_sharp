using System;
using System.Collections.Generic;
using System.Text;

namespace SelfDocumentation.Lab02.Excercise.Sample
{
    /// <summary>
    /// The Space Station is represented by this class!
    /// You can add and remove StructuralElements
    /// You can send Astronauts and bring them back home again
    /// You can also evacuate the station in case of emergency.
    /// With the according method you can run experiments in the station.
    /// <seealso cref="StructuralElement"/>
    /// <seealso cref="Astronaut"/>
    /// </summary>
    class SpaceStation
    {
        public readonly IList<StructuralElement> structure = new List<StructuralElement>();
        public readonly IList<Astronaut> crew = new List<Astronaut>();

        /// <summary>
        /// Call this to evacuate the station
        /// </summary>
        public int emergencyEvacuate()
        {
            // ...
            return 0;
        }

        public long runExperiment(Experiment experiment)
        {
            // ...
            return 0;
        }
    }
}
