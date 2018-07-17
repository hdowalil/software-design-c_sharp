using DependencyInversion.Lab01.Excercise.Challenge.Spacestation;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace DependencyInversion.Lab01.Excercise.Challenge.Universe
{
    public class Space
    {
        private IList<Debris> allDebrisInSpace = new List<Debris>();

        private SpaceStation station = null;

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

        public Space DeployDebris(Debris debris)
        {

            if (allDebrisInSpace.Contains(debris))
            {
                throw new ArgumentException();
            }

            if (debris is SpaceStation) {
                this.station = (SpaceStation)debris;
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

            if (station != null)
            {
                station.DebrisHasMoved(debris);
            }

        }

        public bool WillDebrisMaybeCollideSoonWithAnyOtherDebris(Debris input)
        {
            Contract.Requires(input != null);

            return allDebrisInSpace.Where(d => input.IsCloseTo(d)).Any();
        }

    }
}
