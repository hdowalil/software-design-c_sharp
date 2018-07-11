using System;
using System.Diagnostics.Contracts;

namespace ContractAndAPI.Lab01.Excercise.Solution.Trainer
{
    public class InputAndOutput
    {
        public static string ChooseFromList(int from, int to, params string[] options)
        {
            Contract.Requires(options != null);
            Contract.Requires<ArgumentException>(from >= 0);
            Contract.Requires<ArgumentOutOfRangeException>(options.Length < to);

            int range = to - from;
            int chosen = -1;

            do
            {
                Console.WriteLine("Please choose:");
                for (int i = 0; i < range; i++)
                {
                    Console.WriteLine($"{i + 1}: {options[from + i]}");
                }

                String input = null;
                do
                {
                    input = Console.ReadLine();

                } while (!int.TryParse(input, out chosen));

            } while (chosen <= 0 || chosen > range);

            string result = options[chosen + from - 1];

            Contract.Ensures(result != null);

            return result;
        }

        public static void Main(string[] args)
        {
            string chosen = ChooseFromList(2, 4, "Apple", "Banana", "Strawberry", "PineApple");
            Console.WriteLine(chosen);
            Console.ReadLine();
        }
    }
}
