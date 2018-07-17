using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab01.Excercise.Solution.Trainer.Spacestation
{
    /// <summary>
    /// There is no green alert. No alert at all means, everything is just fine
    /// </summary>
    public enum Alert
    {
        /// <summary>
        /// Do something about the problem!
        /// </summary>
        Yellow = 1,

        /// <summary>
        /// Use escape pods, if there are any, immediatly
        /// </summary>
        Red = 2
    }
}
