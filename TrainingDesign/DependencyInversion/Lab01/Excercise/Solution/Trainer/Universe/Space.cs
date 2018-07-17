using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace DependencyInversion.Lab01.Excercise.Solution.Trainer.Universe
{
    public class Space
    {
        private IList<Debris> allDebrisInSpace = new List<Debris>();
        private IList<IDebrisMovementObserver> allDebrisMovementObserver = new List<IDebrisMovementObserver>();

        public Debris GetDebris(int index)
        {
            return allDebrisInSpace[index];
        }

        public int GetNumberOfDebris()
        {
            return allDebrisInSpace.Count;
        }

        void Clear()
        {
            allDebrisInSpace.Clear();
        }

        public Space AddObserver(IDebrisMovementObserver observer)
        {
            Contract.Requires(observer != null);

            allDebrisMovementObserver.Add(observer);

            Contract.Ensures(allDebrisMovementObserver.Count > 0);

            return this;
        }

        public Space DeployDebris(Debris debris)
        {

            if (allDebrisInSpace.Contains(debris))
            {
                throw new ArgumentException();
            }

            allDebrisInSpace.Add(debris);

            return this;
        }

        public Debris DeployDebris(long positionX, long positionY, long positionZ, int extent)
        {

            Debris debris = new Debris(positionX, positionY, positionZ, extent);

            allDebrisInSpace.Add(debris);

            return debris;
        }

        /// <summary>
        /// Debris should only be moved by this method, so that we can call their collision methods
        /// </summary>
        /// <param name="debris"></param>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        /// <param name="deltaZ"></param>        
        public void MoveDebris(Debris debris, int deltaX, int deltaY, int deltaZ)
        {
            Contract.Requires(debris != null);

            if (Math.Abs(deltaX) > 1 || Math.Abs(deltaY) > 1 || Math.Abs(deltaZ) > 1)
            {
                throw new ArgumentException("can move debris only slowly, 1 unit per time");
            }

            debris.Move(deltaX, deltaY, deltaZ);

            IEnumerable<Debris> collidingDebris = allDebrisInSpace.Where(d => d.IsCollision(debris));
            foreach (Debris d in collidingDebris)
            {
                d.Collide(debris);
                debris.Collide(d);
            }

            foreach (IDebrisMovementObserver observer in allDebrisMovementObserver)
            {
                observer.DebrisHasMoved(debris);
            }

        }

        public bool WillDebrisMaybeCollideSoonWithAnyOtherDebris(Debris input)
        {
            Contract.Requires(input != null);

            return allDebrisInSpace.Where(d => input.IsCloseTo(d)).Any();
        }

    }
}
