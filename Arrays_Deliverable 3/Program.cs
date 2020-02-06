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
            // Manually populate an array with a number of elements input by the user
            int[] countdown = {1, 2, 3, 4, 5 ,6 ,7 ,8 ,9 ,10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25};
            // call variable pop_array to reset countdown.
            
            // Iterate through the array using a For Loop
            foreach (int i in countdown)
            {
                //write "Element Value" and the number in array.
                Console.WriteLine("Element Value = " + i);
            }
        }
    }
}
