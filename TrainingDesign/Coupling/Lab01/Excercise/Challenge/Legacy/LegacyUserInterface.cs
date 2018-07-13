using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Excercise.Challenge.Legacy
{
    class LegacyUserInterface
    {
        private IPersonSearchProvider searchApi;

        public LegacyUserInterface(IPersonSearchProvider searchApi)
        {
            this.searchApi = searchApi;
        }

        public void RunConsole()
        {

            char entry = '0';

            while ('1' != entry)
            {
                Console.WriteLine();
			    Console.WriteLine("1 ... Quit");
                Console.WriteLine("2 ... Search for People by Name");
                Console.WriteLine("3 ... Search for People by ZipCode");

                entry = Console.ReadKey().KeyChar;

                if ('2' == entry)
                {
                    SearchByNameConsole();
                }
                else if ('3' == entry)
                {
                    SearchByNameZipCode();
                }

            }

        }

        private void SearchByNameConsole()
        {
            Console.WriteLine();
		    Console.Write("Please enter name, that you want to search for: ");
            String entry = Console.ReadLine();

            IList<Person> result = searchApi.SearchByName(entry);

            if (result == null || result.Count == 0)
            {
			    Console.WriteLine("Nothing found!");
            }
            else
            {
                DisplayList(result);
            }
        }

        private void SearchByNameZipCode()
        {
            Console.WriteLine();
            Console.Write("Please enter the zip-code, that you want to search for: ");
            String entry = Console.ReadLine();

            if (int.TryParse(entry, out int zip))
            {
                IList<Person> result = searchApi.SearchByZipCode(zip);

                if (result == null || result.Count == 0)
                {
				    Console.WriteLine("Nothing found!");
                }
                else
                {
                    DisplayList(result);
                }
            }

        }


        private void DisplayList(IList<Person> result)
        {

            long choice = -1;

            while (choice != 0)
            {

                foreach (Person p in result)
                {
                    Console.WriteLine(p.ToString()); // !!!
                }
			    Console.Write("Type 0 to get back to main console, or the id of the person you want to display: ");

                char entry = Console.ReadKey().KeyChar;

                if (Char.IsNumber(entry))
                {
                    choice = entry - '0';
                    if (choice != 0)
                    {
                        Person pers = searchApi.ReadById(choice);
                        if (pers != null)
                        {
						    Console.WriteLine(pers.ToString());
                        }
                    }
                }
            }
        }

    }
}
