using Inheritance.Lab02.Excercise.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Excercise.Challenge
{
    class PersonalKen : Ken
    {
        public readonly string OwnersName;

        public PersonalKen(string ownersName)
        {
            OwnersName = ownersName;
        }

        public override string Speak()
        {
            return String.Format("Hello {0}, {1}", OwnersName, base.Speak());
        }

    }
}
