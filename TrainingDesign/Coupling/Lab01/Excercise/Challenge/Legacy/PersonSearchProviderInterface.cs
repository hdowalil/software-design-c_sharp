using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Excercise.Challenge.Legacy
{
    interface PersonSearchProviderInterface
    {
        Person ReadById(long id);

        IList<Person> SearchByName(string nameInput);

        IList<Person> SearchByZipCode(int zipInput);
    }
}
