using System;
// provides us various methods to use in an array
using System.Linq;

namespace ArraysWorld
{
    class Array
    {
        static void Main(string[] args)
        {
            //datatype[] arrayName and memory allocation;
            int[] age = new int[4];
            age[0] = 10;
            age[1] = 20;
            age[2] = 30;
            age[3] = 50;

            //Array initialization
            int[] numbers = {1,2,3,4,5};

            //Iterating using for loop
            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine("Age in index " + i + ":" + age[i]);
            }

            //Iterating using for each
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
            //Min() returns the smallest number in an array
            Console.WriteLine("Smallest  Element: " + numbers.Min());

            // Max() returns the largest number in an array
            Console.WriteLine("Largest Element: " + numbers.Max());

            //Multidimensional array
            //Every element in the array is an array
            int[,] multiArray = { { 1, 2, 3 }, { 3, 4, 5 } };
            Console.WriteLine("Multidimensional array");
            //loop that iterates over the rows of the multiArray. 
            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                //inner loop iterates over the columns of the multiArray
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    Console.Write(multiArray[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}