using System;
using System.Collections.Generic;
using System.Text;

namespace SelfDocumentation.Lab01.Sample.Challenge
{
    public class MyObject
    {
        public readonly long Value;
        public readonly bool Related;
        public readonly int Percentage;
        public readonly int Years;
        public readonly bool Ext;

        public MyObject(bool related, int percentage, int years, bool ext)
        {
            Related = related;
            Percentage = percentage;
            Years = years;
            Ext = ext;

            if ((percentage >= 50 && years > 2 && !ext) || related)
            {
                Value = 2000;
            }
            else
            {
                Value = 1000;
            }
        }

    }
}
