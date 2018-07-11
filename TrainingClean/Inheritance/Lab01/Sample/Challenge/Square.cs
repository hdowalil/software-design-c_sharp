using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab01.Sample.Challenge
{
    public class Square : Rectangle
    {
        public override void SetHeight(int widthAndHeight)
        {
            base.SetWidth(widthAndHeight);
            base.SetHeight(widthAndHeight);
        }

        public override void SetWidth(int widthAndHeight)
        {
            base.SetWidth(widthAndHeight);
            base.SetHeight(widthAndHeight);
        }
    }
}
