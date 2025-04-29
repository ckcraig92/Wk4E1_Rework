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
                n = Convert.ToInt32(Console.ReadLine()); //convert to int

                int[] numbers = new int[n]; //create array

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
                for (int i = 0; i < array.Length; i++)//loop through each postion in array
                {
                    Console.WriteLine(array[i]);
                }
            }

            //method to calculate the sum
            static void PrintSum(int[] array)
            {
                int sum = 0; //initalize at 0

                for (int i = 0; i < array.Length; i++) //loop through to add each to sum
                {
                    sum = sum + array[i];
                }

                Console.WriteLine("Sum of all elements: " + sum); //print for user to view
            }

            // Method to find and print the maximum and minimum values
            static void PrintMaxMin(int[] array)
            {
                int max = array[0];
                int min = array[0];

            //loop to determine min & max
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
                //print for user to view
                Console.WriteLine("Maximum value: " + max);
                Console.WriteLine("Minimum value: " + min);
            }

            //method to reverse & print
            static void ReverseArray(int[] array)
            {
                Console.WriteLine("Reversed array:");//print for user to view
                for (int i = array.Length - 1; i >= 0; i--) //start last & move back
                {
                    Console.WriteLine(array[i]); //print for user to view
                }
            }
        }
    }


