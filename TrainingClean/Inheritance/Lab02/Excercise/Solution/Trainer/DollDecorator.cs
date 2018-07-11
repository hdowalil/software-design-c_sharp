using Inheritance.Lab02.Excercise.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Excercise.Solution
{
    public abstract class DollDecorator : SpeakingDoll
    {
        public readonly SpeakingDoll Delegate;

        protected DollDecorator(SpeakingDoll @delegate)
        {
            Delegate = @delegate;
        }

        public virtual string Speak()
        {
            return Delegate.Speak();
        }
    }
}
