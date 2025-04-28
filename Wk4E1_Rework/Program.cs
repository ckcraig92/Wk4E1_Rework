using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4E1_Rework
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Declarations
                int n;

                //ask for user input
                Console.WriteLine("Enter the number:");
                n = Convert.ToInt32(Console.ReadLine());

                int[] numbers = new int[n];

                //create methods
                InputArray(numbers);
                PrintArray(numbers);
                PrintSum(numbers);
                PrintMaxMin(numbers);
                ReverseArray(numbers);
            }
        //method to ask user to input the elements of hte number
            static void InputArray(int[] array)
            {
                Console.WriteLine("Enter the elements:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Element " + (i + 1) + ": ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //method to print
            static void PrintArray(int[] array)
            {
                Console.WriteLine("Array elements are:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            //method to calculate the sum
            static void PrintSum(int[] array)
            {
                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sum = sum + array[i];
                }

                Console.WriteLine("Sum of all elements: " + sum);
            }

            // Method to find and print the maximum and minimum values
            static void PrintMaxMin(int[] array)
            {
                int max = array[0];
                int min = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }

                Console.WriteLine("Maximum value: " + max);
                Console.WriteLine("Minimum value: " + min);
            }

            //method to reverse & print
            static void ReverseArray(int[] array)
            {
                Console.WriteLine("Reversed array:");
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }


