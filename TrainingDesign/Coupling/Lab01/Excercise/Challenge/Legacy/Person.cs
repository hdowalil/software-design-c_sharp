using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Excercise.Challenge.Legacy
{
    class Person
    {
        public long Id;
        public String GivenName;
        public String SurName;

        // ISO 8601-Format: year-month-day
        public String Born;

        public String Street;
        public String HouseNumber;
        public String ZipCode;
        public String City;

        public Person()
        {
        }

        public Person(long id, string givenName, string surName, string born, string street, string houseNumber, string zipCode, string city)
        {
            this.Id = id;
            this.GivenName = givenName;
            this.SurName = surName;
            this.Born = born;
            this.Street = street;
            this.HouseNumber = houseNumber;
            this.ZipCode = zipCode;
            this.City = city;
        }

        public override string ToString()
        {
            return $"{Id},{GivenName},{SurName},{Born},{Street},{HouseNumber},{ZipCode},{City}";
        }
    }
}
