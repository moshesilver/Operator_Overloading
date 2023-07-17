using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please choose a numerator for fraction 1\n\t\tdenominator for fraction 1\n\t\tnumerator for fraction 2\n\t\tdenominator for fraction 2");
            Fraction f1 = new Fraction(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Fraction f2 = new Fraction(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            Fraction fSum = f1 + f2;
            Fraction fDif = f1 - f2;
            Fraction fProd = f1 * f2;
            Fraction fQuot = f1 / f2;

            Console.Write("Sum: ");
            Fraction.Display(fSum);
            Console.Write("Difference: ");
            Fraction.Display(fDif);
            Console.Write("Product: ");
            Fraction.Display(fProd);
            Console.Write("Quotient: ");
            Fraction.Display(fQuot);
        }
    }
}
    
           
