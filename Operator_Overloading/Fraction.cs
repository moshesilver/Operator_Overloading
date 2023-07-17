using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    public class Fraction
    {
        //FIELDS
        private double numerator;
        private double denominator;

        //CONSTRUCTORS
        public Fraction(double numerator, double denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        
        //OPERATOR OVERLOADS
        public static Fraction operator+ (Fraction a, Fraction b)
        {
            double nSum = a.numerator + b.numerator;
            double dSum = a.denominator + b.denominator;
            return new Fraction(nSum, dSum);
        }

        public static Fraction operator- (Fraction a, Fraction b)
        {
            double nDif = a.numerator - b.numerator;
            double dDif = a.denominator - b.denominator;
            return new Fraction(nDif, dDif);
        }

        public static Fraction operator* (Fraction a, Fraction b)
        {
            double nProd = a.numerator * b.numerator;
            double dProd = a.denominator * b.denominator;
            return new Fraction(nProd, dProd);
        }

        public static Fraction operator/ (Fraction a, Fraction b)
        {
            double nQuot = a.numerator / b.numerator;
            double dQuot = a.denominator / b.denominator;
            return new Fraction(nQuot, dQuot);
        }

        //PROPERTIES
        public double Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public double Denominator
        {
            get { return denominator; }
            set
            {
                if (value != Math.Round(value))
                {
                    Console.WriteLine("invalid input");
                }
                else 
                {
                    Console.WriteLine("haha");
                    denominator = value; 
                }
            }
        }

        //METHODS
        public double Simplify(double n, double d, out double o)
        {
            if (((n / 2) == Math.Round(n / 2)) && ((d / 2) == Math.Round(d / 2)))
            {
                n /= 2;
                d /= 2;
            }
            o = d;
            return n;
        }

        public static void Display(Fraction fTotal)
        {
            Console.WriteLine($"{fTotal.Numerator}/{fTotal.Denominator}");
        }

        //DESTRUCTORS


    }
}
