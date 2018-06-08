using System;
using System.Collections.Generic;
using System.Text;

namespace SelfDocumentation.Lab02.Excercise.Solution
{
    /// <summary>
    /// Please bear in mind these contraints when using this class:
    /// <list type = "bullet" >
    /// <item>
    /// <description>here always has to be at least one StructuralElement, 
    /// do not remove the Core-Element supplied in the constructor</description>
    /// </item>
    /// <item>
    /// <description>To run an Experiment you will have to have at least one Astronaut on board</description>
    /// </item>
    /// </list>   
    /// Sample usage:
    /// <code>
    /// StructuralElement coreElement = new StructuralElement();
    /// SpaceStation station = new SpaceStation(coreElement);
    ///
    /// Astronaut alice = new Astronaut();
    /// Astronaut bob = new Astronaut();
    /// station.sendAstronauts(alice, bob);
    /// Debug.Assert(station.isAstronautOnBoard(alice));
    /// Debug.Assert(station.isAstronautOnBoard(bob));
    ///
    /// Experiment experiment2Run = new Experiment();
    /// long result = station.runExperiment(experiment2Run);
    /// Console.WriteLine($"Experiment result is: {result}");
    ///
    /// Debug.Assert(2 == station.emergencyEvacuate());
    /// </code>
    /// </summary>
    public class SpaceStation
    {
        private readonly StructuralElement CoreElement;

        public SpaceStation(StructuralElement coreElement)
        {
            CoreElement = coreElement;
        }

        public SpaceStation()
        {
            CoreElement = new StructuralElement();
        }

        public void addElement(StructuralElement element)
        {
            // Dummy Method Body
        }

        public void removeElement(StructuralElement element)
        {
            // Dummy Method Body
        }

        public void sendAstronauts(params Astronaut[] astronauts)
        {
            // Dummy Method Body
        }

        public bool isAstronautOnBoard(Astronaut astronaut)
        {
            // Dummy Method Body
            return true;
        }

        public void getAstronautBackHome(Astronaut astronaut)
        {
            // Dummy Method Body
        }

        /// <summary>
        /// Use this method, in case of a problem on the Station. 
        /// Otherwise just bring them back using <see cref="getAstronautBackHome(Astronaut)"/>
        /// </summary>
        /// <returns>Number of Astronauts that we were able to evacuate </returns>
        public int emergencyEvacuate()
        {
            // Dummy Method Body
            return 0;
        }

        /// <summary>
        /// You can use this method if you have at least one <see cref="Astronaut"/> on board. 
        /// </summary>
        /// <param name="experiment">The experiment, that you want to run. Must not be null</param>
        /// <returns>The result of the Experiment</returns>
        public long runExperiment(Experiment experiment)
        {
            // Dummy Method Body
            return 0L;
        }

    }
}
