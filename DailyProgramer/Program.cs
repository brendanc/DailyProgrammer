using DailyProgramer.DogContest;
using DailyProgramer.Permutations;
using System;
using System.Linq;

namespace DailyProgramer
{
    class Program
    {
        static void Main(string[] args)
        {

            var command = GetInput("Enter a command:");
            var validCommands = new[] {"permuation","combination","dog" };

            if (!validCommands.Contains(command)) throw new ArgumentException("Not a valid command.");

            try {
                if(command == "permuation" || command == "combination")
                {
                    PermutationsAndCombinations(command);
                }
                if(command == "dog")
                {
                    RunDogContest();
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine("Oops: {0}",exception);
            }

            Console.ReadLine();
        }

        private static string GetInput(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        private static int GetInputAsInt(string text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// https://www.reddit.com/r/dailyprogrammer/comments/4hhiu8/20160502_challenge_265_easy_permutations_and/
        /// </summary>
        /// <param name="command"></param>
        private static void PermutationsAndCombinations(string command)
        {
            var factor = GetInputAsInt("How big a tree?");
            if (command == "permutation")
            {
                var permutation = new Permutation(factor);
                var tree = permutation.GenerateTree();
                foreach (var t in tree)
                {
                    Console.WriteLine(t);
                }


                var index = GetInputAsInt("Which index would you like?");
                var answer = tree.ElementAt(index - 1);
                Console.WriteLine("The {0} permutation of {1} is {2}", index, factor, answer);
            }

            if (command == "combination")
            {
                var size = GetInputAsInt("Max size?");
                var index = GetInputAsInt("Which index would you like?");

                var combo = new Combination(factor, size);
                var tree = combo.GenerateTree();
                var answer = tree.ElementAt(index - 1);
                Console.WriteLine("The {0} combination number of {1} out of {2} us {3}", index, size, factor, answer);
            }
        }

        /// <summary>
        /// https://www.reddit.com/r/dailyprogrammer/comments/4jom3a/20160516_challenge_267_easy_all_the_places_your/
        /// </summary>
        private static void RunDogContest()
        {
            var totalDogs = GetInputAsInt("How many dogs are in the contest?");
            var myDog = GetInputAsInt("What place was your dog?");
            Contest.Run(totalDogs, myDog);
        }
    }
}
