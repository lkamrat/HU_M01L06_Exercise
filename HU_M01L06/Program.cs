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
            // Q1 - Print 5 numbers in reverse order.  
            int[] newArray = new int[5];

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                newArray[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(newArray);
            foreach (int value in newArray)
            {
                Console.WriteLine("\n" + value);
            }

            // Q1 - Print 5 numbers in reverse order. This is using reverse input. 
            int[] reverseArray = new int[5];
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine("Please enter a number");
                reverseArray[i] = int.Parse(Console.ReadLine());
            }
            foreach (int value in reverseArray)
            {
                Console.WriteLine("\n" + value);
            }

            // Q2 - Print only even numbers in a 5 numbers array
            int[] intArrayA = new int[5];
            for (int i = 0; i < intArrayA.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                intArrayA[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < intArrayA.Length; i++)
            {
                if (intArrayA[i] % 2 == 0)
                {
                    Console.WriteLine(intArrayA[i] + " is an even number");
                }
            }

            // Q3 - Print only negetive numbers in a 5 numbers array
            int[] intArrayB = new int[5];
            for (int i = 0; i < intArrayB.Length; i++)
            {
                Console.WriteLine("Please enter a positive or a negetive number");
                intArrayB[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < intArrayB.Length; i++)
            {
                if (intArrayB[i] < 0)
                {
                    Console.WriteLine(intArrayB[i] + " is a negetive number");
                }
            }

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

            // Q5 - Print the lowest number in a 5 numbers array
            int[] intArrayD = new int[5];
            int lowestNum = 0;

            for (int i = 0; i < intArrayC.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                intArrayD[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < intArrayD.Length; i++)
            {
                if (intArrayD[i] < lowestNum)
                {
                    lowestNum = intArrayD[i];
                }
            }
            Console.WriteLine("The lowest number in this array is " + lowestNum);


            // Q6 - Sort numbers in an ascending order in a new array
            int[] newArrayA = new int[5];
            int[] oldArrayA = new int[5];
            int max = 0;
            int tempA = 0;

            for (int i = 0; i < oldArrayA.Length; i++)
            {
                Console.WriteLine("Please enter 5 numbers");
                oldArrayA[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < newArrayA.Length; i++)
            {
                max = 0;
                tempA = 0;
                for (int j = 0; j < oldArrayA.Length; j++)
                {
                    if (oldArrayA[j] > max)
                    {
                        max = oldArrayA[j];
                        tempA = j;
                    }

                }
                newArrayA[i] = max;
                oldArrayA[tempA] = 0;
            }
            for (int i = 0; i < newArrayA.Length; i++)
            {
                Console.Write(newArrayA[i] + " ");
            }

            // Q7 - Sort numbers in a decending order in a new array
            int[] newArrayB = new int[5];
            int[] oldArrayB = new int[5];
            int min;
            int tempB = 0;

            for (int i = 0; i < oldArrayB.Length; i++)
            {
                Console.WriteLine("Please enter 5 numbers");
                oldArrayB[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < newArrayB.Length; i++)
            {
                min = int.MaxValue;
                tempB = 0;
                for (int j = 0; j < oldArrayB.Length; j++)
                {
                    if (oldArrayB[j] < min)
                    {
                        min = oldArrayB[j];
                        tempB = j;
                    }

                }
                newArrayB[i] = min;
                oldArrayB[tempB] = int.MaxValue;
            }
            for (int i = 0; i < newArrayB.Length; i++)
            {
                Console.Write(newArrayB[i] + " ");
            }

            int[] newArray = new int[5];
            int a;

            // Sort numbers in an ascending order in a new array using Bubble Sorting
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine("Please enter 5 numbers");
                newArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = 1; j <= newArray.Length; j++)
                {
                    if (newArray[j-1] < newArray[j])
                    {
                        a = newArray[j];
                        newArray[j] = newArray[j - 1];
                        newArray[j - 1] = a;
                    }
                }
            }
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }

        }
    }
}
