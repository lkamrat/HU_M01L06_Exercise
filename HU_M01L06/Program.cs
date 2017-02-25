using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HU_M01L06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1 - Print user input numbers in reverse order 
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


        }
    }
}
