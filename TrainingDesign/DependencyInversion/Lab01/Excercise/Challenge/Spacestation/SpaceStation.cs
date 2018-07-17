using DependencyInversion.Lab01.Excercise.Challenge.Universe;
using System.Diagnostics.Contracts;

namespace DependencyInversion.Lab01.Excercise.Challenge.Spacestation
{
    public class SpaceStation : Debris
    {
        private const int StationSize = 10;

        private Space space = null;

        public bool Collision { get; private set; }  = false;
        public Alert? CurrentAlert { get; private set; }  = null;

        public SpaceStation(Space space, long positionX, long positionY, long positionZ) 
            : base (positionX, positionY, positionZ, StationSize)
        {
            this.space = space;
            this.space.DeployDebris(this);
            CollisionConsumer = ((d) => {
                CollisionHappened();
            });
        }

        private void CollisionHappened()
        {
            Collision = true;
            check4Alert();
        }

        public void DebrisHasMoved(Debris debrisThatHasMoved)
        {
            Contract.Requires(debrisThatHasMoved != null);

            // we were called by space, that sthg has happend
            check4Alert();
        }

        private Alert? check4Alert()
        {

            if (Collision)
            {
                CurrentAlert = Alert.Red;
                // evacuate ship!
            }
            else if (space.WillDebrisMaybeCollideSoonWithAnyOtherDebris(this))
            {
                CurrentAlert = Alert.Yellow;
            }
            else
            {
                CurrentAlert = null;
            }

            return CurrentAlert;
        }

        public void MoveLeft()
        {
            _Move(-1, 0, 0);
        }

        public void MoveRight()
        {
            _Move(1, 0, 0);
        }

        public void MoveUp()
        {
            _Move(0, 1, 0);
        }

        public void MoveDown()
        {
            _Move(0, -1, 0);
        }

        public void MoveBackwards()
        {
            _Move(0, 0, -1);
        }

        public void MoveForward()
        {
            _Move(0, 0, 1);
        }

        private void _Move(int deltaX, int deltaY, int deltaZ)
        {
            space.MoveDebris(this, deltaX, deltaY, deltaZ);
            // should trigger debrishasmoved, that will call check4alert to check for debris closing in
        }

    }
}
