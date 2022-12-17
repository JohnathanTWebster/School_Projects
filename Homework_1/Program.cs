using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*\
 Write a Visual Studio 2019 Console Application that calculates and displays the conversion of an entered number of dollars into currency 
 denominations—twenties, tens, fives, and ones. 
 For example, $113 is 5 twenties, 1 ten, 0 fives, and 3 ones.
 
 */

namespace Homework_1
{
    class Program
    {


        static void Main(string[] args)
        {

            //storage containers for input and conversions
            int inputConvertion;
            string input;
            int twenties, tens, fives, ones;

            //constants
            int TWENTY = 20,TEN = 10,FIVE = 5,ONE = 1;          

            //ask user for input
            Console.Write("Please enter a whole number: ");

            //assign input to container
            input = Console.ReadLine(); 

            //convert string to int32bit
            inputConvertion = Convert.ToInt32(input);

            //find number of 20s
            twenties = inputConvertion / TWENTY;

            //update number
            inputConvertion -= (twenties * TWENTY);

            //find number of 10s
            tens = inputConvertion / TEN;
            
            //update number
            inputConvertion -= (tens * TEN);

            //find number of 5s
            fives = inputConvertion / FIVE;

            //update number
            inputConvertion -= (fives * FIVE);

            //find number of ones
            ones = inputConvertion / ONE;

            //update number
            inputConvertion -= (ones * ONE);


            //display results of findings
            Console.Write("$" + input + " is " + twenties + " twenties " + tens + " tens " + fives + " fives and " + ones +" ones" );

            //prevents application from closing
            Console.ReadLine();

        }
    }
}
