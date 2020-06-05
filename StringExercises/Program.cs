using System;
using System.Linq;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

            string[] wordsSplit = words.Split(' ');

            for (int i = 0; i < wordsSplit.Length; i++)
            {
                if (wordsSplit[i].Contains(".")|| wordsSplit[i].Contains(",")) 
                { 
                    wordsSplit[i] = wordsSplit[i].Substring(0, wordsSplit[i].Length - 1); 
                }
            }

            Console.WriteLine(string.Join(",", wordsSplit));
        }
    }
}
