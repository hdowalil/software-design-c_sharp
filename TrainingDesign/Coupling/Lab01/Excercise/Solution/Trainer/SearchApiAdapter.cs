using Coupling.Lab01.Excercise.Challenge.Cots;
using Coupling.Lab01.Excercise.Challenge.Legacy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Excercise.Solution.Trainer
{
    class SearchApiAdapter : PersonSearchProviderInterface
    {
        public Coupling.Lab01.Excercise.Challenge.Legacy.Person ReadById(long id)
        {
            return ConvertCotsPersonToLegacyPerson(SearchApi.ReadPerson(id));
        }

        public IList<Coupling.Lab01.Excercise.Challenge.Legacy.Person> SearchByName(string nameInput)
        {
            Coupling.Lab01.Excercise.Challenge.Legacy.Person[] result = 
                Array.ConvertAll(SearchApi.FindByName(nameInput), p => ConvertCotsPersonToLegacyPerson(p));
            return new List<Coupling.Lab01.Excercise.Challenge.Legacy.Person>(result);
        }

        public IList<Coupling.Lab01.Excercise.Challenge.Legacy.Person> SearchByZipCode(int zipInput)
        {
            Coupling.Lab01.Excercise.Challenge.Legacy.Person[] result =
                Array.ConvertAll(SearchApi.FindByZipCode(zipInput), p => ConvertCotsPersonToLegacyPerson(p));
            return new List<Coupling.Lab01.Excercise.Challenge.Legacy.Person>(result);
        }

        public static Coupling.Lab01.Excercise.Challenge.Legacy.Person ConvertCotsPersonToLegacyPerson(Coupling.Lab01.Excercise.Challenge.Cots.Person input)
        {
            Coupling.Lab01.Excercise.Challenge.Legacy.Person result = new Coupling.Lab01.Excercise.Challenge.Legacy.Person();

            result.Id = input.Id;
            result.GivenName = input.FirstName;
            result.SurName = input.FamilyName;
            result.Born = input.BirthDay.ToString("yyyy-MM-dd");
            result.Street = input.Street;
            result.HouseNumber = input.AdressLine2;
            result.ZipCode = input.ZipCode.ToString();
            result.City = input.Town;

            return result;
        }
    }
}