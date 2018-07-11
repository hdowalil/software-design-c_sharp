using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab01.Sample.Challenge
{
    public class Rectangle
    {
        private int width;
        private int height;

        public int Area()
        {
            return width * height;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public virtual void SetWidth(int width)
        {
            this.width = width;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public virtual void SetHeight(int height)
        {
            this.height = height;
        }
    }
}
