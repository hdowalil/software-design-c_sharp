using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Excercise.Challenge.Cots
{
    class Person
    {
        public long Id;
        public string FirstName;
        public string FamilyName;
        public DateTime BirthDay;
        public string Street;
        public string AdressLine2;
        public int ZipCode;
        public string Town;

        public Person(long id, string firstName, string familyName, DateTime birthDay, string street, string adressLine2, int zipCode, string town)
        {
            Id = id;
            FirstName = firstName;
            FamilyName = familyName;
            BirthDay = birthDay;
            Street = street;
            AdressLine2 = adressLine2;
            ZipCode = zipCode;
            Town = town;
        }
    }
}
