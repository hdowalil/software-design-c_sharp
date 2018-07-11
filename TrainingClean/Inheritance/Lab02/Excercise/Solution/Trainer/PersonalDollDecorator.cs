using Inheritance.Lab02.Excercise.Common;
using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Excercise.Solution
{
    public class PersonalDollDecorator : DollDecorator
    {
        public readonly string OwnersName;

        public PersonalDollDecorator(String ownersName, SpeakingDoll @delegate) 
            : base (@delegate) {

            Contract.Requires(ownersName != null);
            OwnersName = ownersName;
	    }

        public override string Speak()
        {
            return String.Format("Hello {0}, {1}", OwnersName, base.Speak());
        }

    }
}
