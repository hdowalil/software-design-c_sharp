using System;
using System.Collections.Generic;
using System.Linq;

namespace Modularization.Lab02.Solution.Trainer.Portal
{
    class AllGamesConsole
    {
        private IDictionary<string, int> highScores = new Dictionary<string, int>();

        private IEnumerable<Type> PlugIns(Type serviceInterface)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => !p.IsAbstract && !p.IsInterface && serviceInterface.IsAssignableFrom(p));
        }

        public void Run()
        {
            IEnumerable<Type> consoleTypes = PlugIns(typeof(IGameConsole));
            IList<IGameConsole> games = consoleTypes.Select(st => (IGameConsole)Activator.CreateInstance(st)).ToList();

            int menuChoice = -1;

            while (menuChoice != 0)
            {

                PrintHighScores();
                Console.WriteLine("0 .. Quit");
                Console.WriteLine("Or fancy playing one of these games?");
                for (int i = 0; i < games.Count; i++)
                {
                    Console.WriteLine("{0} .. {1}", i + 1, games[i].Name());
                }

                bool numeric = Int32.TryParse(Console.ReadLine(), out menuChoice);
                if (numeric)
                {

                    if (menuChoice <= games.Count && menuChoice > 0)
                    {
                        int indexOfGameInList = menuChoice - 1;
                        IGameConsole console = games[indexOfGameInList];
                        int score = console.Run();
                        HighScore(console.Name(), score);
                    }
                }
            }
		}
	
        private void PrintHighScores()
        {
            if (highScores.Count > 0)
            {
			    Console.WriteLine("Highscores:");
                foreach (KeyValuePair<string, int> highScore in highScores)
                {
                    Console.WriteLine("{0}: {1}", highScore.Key, highScore.Value);
                }
            }
        }

        private void HighScore(string game, int score)
        {
            if (highScores.ContainsKey(game))
            {
                if (score > highScores[game])
                {
                    highScores[game] = score;
                }
            }
            else
            {
                highScores[game] = score;
            }
        }

        static void Main(string[] args)
        {
            (new AllGamesConsole()).Run();
        }
    }
}
