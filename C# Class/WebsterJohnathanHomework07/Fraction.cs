using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsterJohnathanHomework7
{
    class Fraction
    {
        //properties
        private int wholeNum;
        private int numerator;
        private int denominator;


        //constructors

        public Fraction(int wholeNum, int numerator, int denominator)
        {
            this.wholeNum = wholeNum;
            this.numerator = wholeNum * denominator + numerator;

            Reduce();
        }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.wholeNum = 0;
            Reduce();
        }

        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
            this.wholeNum = 0;
        }


        //getters and setters

        public int getNumerator()
        {
            return this.numerator;
        }
        public int getDenominator()
        {
            return this.denominator;
        }
        public int getWholeNum()
        {
            return this.wholeNum;
        }

        public void setNumerator(int numerator)
        {
            this.numerator = numerator;
        }
        public void setDenominator(int denominator)
        {
            this.denominator = denominator;
        }
        public void setWholeNum(int wholeNum)
        {
            this.wholeNum = wholeNum;
        }


        //methods


        //reduces the fraction if improper
        public void Reduce()
        {
            if(numerator < denominator)
            {
                wholeNum = 0;
                return;
            }
            if(numerator == denominator)
            {
                wholeNum = 1;
                numerator = 0;
                return;
            }
            if(numerator > denominator)
            {
                wholeNum = (int)Math.Floor((decimal)numerator / denominator);
                numerator -= wholeNum * denominator;
            }
        }

        //replaces the '+' operator to perform calc to return fractions added together
        public static Fraction operator+(Fraction firstFraction, Fraction secondFraction)
        {
            if (firstFraction.denominator == secondFraction.denominator)
            {
                int firstProduct = (firstFraction.wholeNum * firstFraction.denominator) + firstFraction.numerator;
                int secondProduct = (secondFraction.wholeNum * secondFraction.denominator) + secondFraction.numerator;
                return (new Fraction(firstProduct + secondProduct, firstFraction.denominator));
            }
            else
            {
                int commondenominator = firstFraction.denominator * secondFraction.denominator;
                int firstProduct = ((firstFraction.wholeNum * firstFraction.denominator) + firstFraction.numerator) * secondFraction.denominator;
                int secondProduct = ((secondFraction.wholeNum * secondFraction.denominator) + secondFraction.numerator) * firstFraction.denominator;
                return (new Fraction(firstProduct + secondProduct, commondenominator));
            }
        }
        

        

    }
}
