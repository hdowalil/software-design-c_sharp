using System;
using System.Collections.Generic;
using System.Text;

namespace ContractAndAPI.Lab03.Sample.Solution
{
    class Camera : IVideoRecordingDevice, IPictureRecordingDevice
    {
        private byte[] Shoot(bool film)
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

        public byte[] RecordVideo()
        {
            return Shoot(true);
        }

        public byte[] RecordPicture()
        {
            return Shoot(false);
        }

    }
}
