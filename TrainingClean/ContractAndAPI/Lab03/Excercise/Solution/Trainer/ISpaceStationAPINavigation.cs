using System;
using System.Collections.Generic;
using System.Text;

namespace ContractAndAPI.Lab03.Excercise.Solution.Trainer
{
    interface ISpaceStationAPINavigation
    {
        void MoveLeft();

        void MoveRight();

        void MoveUp();

        void MoveDown();

        void MoveBackwards();

        void MoveForward();
    }
}
