using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsterJohnathanHomework06
{
    class Program
    {
        /*
         Create a Visual Studio 2019 Console Application  whose Main() method declares an array of  10 integers.
        Call a method to interactively fill the array with any number of values up to 10 or until a sentinel value is entered.
        If an entry is not an integer, reprompt the user.
        Call a second method that accepts out parameters for the highest value in the array, lowest value in the array,
        sum of the values in the array, and arithmetic average. In the Main() method, display all the statistics.
         */

        static void Main(string[] args)
        {

            //declare global containers
            int[] mainArray = new int[10];
            const char EXIT = 'x';


            //try the statement below
            try
            {
                //iterate over every position in the array
                for (int loopcontrol = 0; loopcontrol < mainArray.Length; loopcontrol++)
                {
                    //show message to enter a number to exit value
                    Console.WriteLine("Please enter a number or x to exit: ");

                    //if the exit value is entered then exit loop
                    if (mainArray[loopcontrol] == EXIT)
                    {
                        continue;
                    }

                    //add the entered value to the position specified by the loop control
                    mainArray[loopcontrol] = Convert.ToInt32(Console.ReadLine());
                }
            }//incorrect input display message
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            //perfrom calculations
            Statistics_Calc(mainArray);

            //to prevent window from closing 
            Console.ReadLine();

            //Method that calculates all the values
             void Statistics_Calc(int[] arr)
            {
                int largest = arr[0];
                int smallest = arr[0];
                int sum = 0;
                float average;


                //iterate over all elements to gather sum, largest, and smallest numbers
                for (int loopcontrol = 0; loopcontrol < arr.Length; loopcontrol++)
                {
                    sum += arr[loopcontrol];

                    if(largest < arr[loopcontrol])
                    {
                        largest = arr[loopcontrol];
                    }
                    if (smallest > arr[loopcontrol])
                    {
                        smallest = arr[loopcontrol];
                    }
                }

                //calculate average
                average = sum / arr.Length;

                //display messages
                Console.WriteLine("Largest: " + largest);
                Console.WriteLine("Smallest: " + smallest);
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Average: " + average);


            }
        }
    }
}
