using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Excercise.Common
{
    public class Ken : SpeakingDoll
    {
        public virtual string Speak()
        {
            return "I am Ken";
        }
    }
}
