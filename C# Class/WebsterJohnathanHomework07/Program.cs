using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebsterJohnathanHomework7
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare new instances
            Fraction firstfraction = new Fraction();
            Fraction secondfraction = new Fraction();
            Fraction total = firstfraction + secondfraction;
            Console.WriteLine(total);

            //prompt the user and set entered values to specified
            Console.Write("Enter whole number portion of fraction: ");
            firstfraction.setWholeNum(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter numerator: ");
            firstfraction.setNumerator(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter denominator: ");
            firstfraction.setDenominator(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter whole number portion of fraction: ");
            secondfraction.setWholeNum(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter numerator: ");
            secondfraction.setNumerator(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter denominator: ");
            secondfraction.setDenominator(Convert.ToInt32(Console.ReadLine()));
            Console.Write("{0} {1}/{2}", firstfraction.getWholeNum(), firstfraction.getNumerator(),
            firstfraction.getDenominator());
            Console.WriteLine(" + {0} {1}/{2}", secondfraction.getWholeNum(),
            secondfraction.getNumerator(), secondfraction.getDenominator());

            //create new add instance
            Fraction add = new Fraction();
            add = firstfraction + secondfraction;

            //return the final result
            Console.Write("Result of adding two fractions is:{0} {1}/{2}", add.getWholeNum(),
            add.getNumerator(), add.getDenominator());
            Console.ReadLine();

        }
    }
}
