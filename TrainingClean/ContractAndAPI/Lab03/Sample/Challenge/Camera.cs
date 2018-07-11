using System;
using System.Collections.Generic;
using System.Text;

namespace ContractAndAPI.Lab03.Sample.Challenge
{
    class Camera
    {
        public byte[] Shoot(bool film)
        {
            if (film)
            {
                return Encoding.ASCII.GetBytes("This is a fancy film that you just shot");
            }
            else
            {
                return Encoding.ASCII.GetBytes("Picture");
            }
        }
    }

}
