using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversion.Lab01.Excercise.Challenge.Universe
{
    public class Debris
    {
        private const int Close = 100;

        public long PositionX { get; private set; } = 0;
        public long PositionY { get; private set; } = 0;
        public long PositionZ { get; private set; } = 0;
        public readonly int Extent = 1;

        public Action<Debris> CollisionConsumer { private get; set; }

        public Debris(long positionX, long positionY, long positionZ, int extent)
        {
            PositionX = positionX;
            PositionY = positionY;
            PositionZ = positionZ;
            Extent = extent;
        }

        /// <summary>
        /// If this is null, the debris is unnamed. like small meteorites, or space garbage in earths orbit
        /// </summary>
        /// <returns>Name of Debris</returns>
        public virtual string Name()
        {
            return null;
        }

        /// <summary>
        /// when space detects collision with another debris, after debris movement, it will call this
        /// </summary>
        /// <param name="otherDebris"></param>
        public void Collide(Debris otherDebris)
        {
            if (otherDebris != null && CollisionConsumer != null)
            {
                CollisionConsumer.Invoke(otherDebris);
            }
        }

        /// <summary>
        /// this method should only be called by Space class!
        /// </summary>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        /// <param name="deltaZ"></param>
        public void Move(int deltaX, int deltaY, int deltaZ)
        {
            PositionX += deltaX;
            PositionY += deltaY;
            PositionZ += deltaZ;
        }

        /// <summary>
        /// Will determine the maximum distance in one coordiate.
        /// This is interesting, as it is relevant for how close another debris is.
        /// if it is far away in only one coordinate, it is far away.
        /// Imagine there is one lightyear between you and stgh else in z coordinate and others are just same
        /// </summary>
        /// <param name="anotherDebris"></param>
        /// <returns></returns>
        private long MaxDistanceCoordinate(Debris anotherDebris)
        {
            long[] distances = new long[]
            {
                Math.Abs(anotherDebris.PositionX - PositionX),
                Math.Abs(anotherDebris.PositionY - PositionY),
                Math.Abs(anotherDebris.PositionZ - PositionZ)
            };
            return distances.Max();
        }

        public bool IsCloseTo(Debris anotherDebris)
        {

            if (anotherDebris == null || this == anotherDebris)
            {
                // this is not a collision, it is the same debris!
                return false;
            }

            long distance = MaxDistanceCoordinate(anotherDebris);

            return ((distance - Extent) <= Close);
        }

        public bool IsCollision(Debris anotherDebris)
        {

            if (anotherDebris == null || this == anotherDebris)
            {
                // this is not a collision, it is the same debris!
                return false;
            }

            long distance = MaxDistanceCoordinate(anotherDebris);

            int myRadius = (int)Math.Ceiling((double)Extent / 2d);
            int otherRadius = (int)Math.Ceiling((double)anotherDebris.Extent / 2d);
            int bothRadius = myRadius + otherRadius;

            return ((distance - bothRadius) <= 0);
        }


    }
}
