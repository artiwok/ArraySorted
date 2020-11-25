using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorted
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraySorted();
        }

        static void ArraySorted()
        {
            Random rnd = new Random();

            int[] arr = new int[10];

            Console.Write("Random elements of the array are: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10);

                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine("\n");

            Console.Write("The sorted array is: ");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }

                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine("\n");
        }
    }
}
