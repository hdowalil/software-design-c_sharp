using System;

namespace ProgramStructure.Lab01.Sample.Common
{
    class Message
    {
        public string SomeText;
        public long SomeValue;
        public DateTime SomeDate;

        public Message()
        {
        }

        public Message(string someText, long someValue, DateTime someDate)
        {
            SomeText = someText;
            SomeValue = someValue;
            SomeDate = someDate;
        }
    }
}
