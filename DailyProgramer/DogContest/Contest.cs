using System;

namespace DailyProgramer.DogContest
{
    public class Contest
    {
        public static void Run(int totalDogs, int myDog)
        {
            for(var i = 1; i <= totalDogs; i++)
            {
                if(i != myDog)
                {
                    PrintDog(i);
                }
            }
        }

        private static void PrintDog(int place)
        {
             Console.WriteLine(string.Format("{0}{1}", place, GetSuffix(place)));

        }

        private static string GetSuffix(int num)
        {
            if (num.ToString().EndsWith("11")) return "th";
            if (num.ToString().EndsWith("12")) return "th";
            if (num.ToString().EndsWith("13")) return "th";
            if (num.ToString().EndsWith("1")) return "st";
            if (num.ToString().EndsWith("2")) return "nd";
            if (num.ToString().EndsWith("3")) return "rd";
            return "th";
        }
    }
}
