using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HU_M01L06
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            //// Q1 - Print 5 numbers in reverse order.  
            //int[] newArray = new int[5];

            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    Console.WriteLine("Please enter a number");
            //    newArray[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Reverse(newArray);
            //foreach (int value in newArray)
            //{
            //    Console.WriteLine("\n" + value);
            //}

            //// Q1 - Print 5 numbers in reverse order. This is using reverse input. 
            //int[] reverseArray = new int[5];
            //for (int i = 4; i >= 0; i--)
            //{
            //    Console.WriteLine("Please enter a number");
            //    reverseArray[i] = int.Parse(Console.ReadLine());
            //}
            //foreach (int value in reverseArray)
            //{
            //    Console.WriteLine("\n" + value);
            //}

            //// Q2 - Print only even numbers in a 5 numbers array
            //int[] intArrayA = new int[5];
            //for (int i = 0; i < intArrayA.Length; i++)
            //{
            //    Console.WriteLine("Please enter a number");
            //    intArrayA[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //for (int i = 0; i < intArrayA.Length; i++)
            //{
            //    if (intArrayA[i] % 2 == 0)
            //    {
            //        Console.WriteLine(intArrayA[i] + " is an even number");
            //    }
            //}

            //// Q3 - Print only negetive numbers in a 5 numbers array
            //int[] intArrayB = new int[5];
            //for (int i = 0; i < intArrayB.Length; i++)
            //{
            //    Console.WriteLine("Please enter a positive or a negetive number");
            //    intArrayB[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //for (int i = 0; i < intArrayB.Length; i++)
            //{
            //    if (intArrayB[i] < 0)
            //    {
            //        Console.WriteLine(intArrayB[i] + " is a negetive number");
            //    }
            //}

            // Q4 - Print the highest number in a 5 numbers array
            int[] intArrayC = new int[5];
            int highesNum = 0;

            for (int i = 0; i < intArrayC.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                intArrayC[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < intArrayC.Length; i++)
            {
                if (intArrayC[i] > highesNum)
                {
                    highesNum = intArrayC[i];
                }
            }
            Console.WriteLine("The highest number in this array is " + highesNum);

            //// Q5 - Print the lowest number in a 5 numbers array
            //int[] intArrayD = new int[5];
            //int lowestNum = 0;

            //for (int i = 0; i < intArrayC.Length; i++)
            //{
            //    Console.WriteLine("Please enter a number");
            //    intArrayD[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //for (int i = 0; i < intArrayD.Length; i++)
            //{
            //    if (intArrayD[i] < lowestNum)
            //    {
            //        lowestNum = intArrayD[i];
            //    }
            //}
            //Console.WriteLine("The lowest number in this array is " + lowestNum);

            // Q6 - Sort numbers of array in ascending order in a new array
            int[] intArrayE = new int[5];
            int[] newArray = new int[5];
            int max = 0;

            for (int i = 0; i < intArrayE.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                intArrayE[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < intArrayE.Length; i++)
            {
                max = 0;
                for (int j = 0; j < intArrayE.Length; j++)
                {

                }
            }



        }
    }
}
