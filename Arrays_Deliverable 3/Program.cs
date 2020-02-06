/*
    Author: Zhenwei Li
    Date: 02/06/2020
    Comments: This C# Console application code demonstrates the use of
              Arrays without getting any input from users. 

*/

using System;

namespace Arrays_Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {   
            // call local variable for the total amount of numbers in an array
            int number_of_array = 26;
            // Automatically populate an array with a number of elements input by the user
            int[] countdown = new int[number_of_array];
            // call variable pop_array to reset countdown.
            int pop_array = 0;
            // Iterate through the array using a For Loop
            for (int i = 1; i < number_of_array; i++)
            {
                countdown[i] = pop_array;
                //write "Element Value" and the number in array.
                Console.WriteLine("Element Value = " + i);
            }
        }
    }
}
