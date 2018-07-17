using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab01.Excercise.Solution.Trainer.Universe
{
    public interface IDebrisMovementObserver
    {
        void DebrisHasMoved(Debris debrisThatHasMoved);
    }
}
