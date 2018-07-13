using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Excercise.Challenge.Cots
{
    class SearchApi
    {
        public static Person ReadPerson(long id)
        {
            return Array.Find(Database.Data, person => person.Id == id);
        }

        public static Person[] FindByName(string name2Search)
        {
            return Array.FindAll(Database.Data, person => person.FamilyName.Contains(name2Search));
        }

        public static Person[] FindByZipCode(int zipCode2Find)
        {
            return Array.FindAll(Database.Data, person => person.ZipCode == zipCode2Find);
        }

    }
}