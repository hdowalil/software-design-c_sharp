using Inheritance.Lab02.Excercise.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Excercise.Challenge
{
    class PersonalBarbie : Barbie
    {
        public readonly string OwnersName;

        public PersonalBarbie(string ownersName)
        {
            OwnersName = ownersName;
        }

        public override string Speak()
        {
            return String.Format("Hello {0}, {1}", OwnersName, base.Speak());
        }
    }
}
