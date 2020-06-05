using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = { 1, 1, 2, 3, 5, 8 };

            Console.WriteLine("All numbers printed:");
            for (int i = 0;  i < numArr.Length; i++)
            {
                if (i == numArr.Length - 1)
                {
                    Console.WriteLine(numArr[i] + "\n");
                    break;
                }
                Console.WriteLine(numArr[i]);

            }

            Console.WriteLine("Odd numbers printed");
            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i]%2 != 0)
                {
                    Console.WriteLine(numArr[i]);

                }

            }
        }
    }
}
