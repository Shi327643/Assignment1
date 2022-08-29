using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsLibrary;

namespace MathTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate your Equtions");
            Calculator calculator = new Calculator();
            //calculator.Number1 = 50;
            //calculator.Number2 = 10;

            

            Console.WriteLine(calculator);


            Console.WriteLine("Answer is:"+calculator.AddNumber(50,10));
            Console.WriteLine("Answer is:"+calculator.SubtractNumber(50,10));
            Console.WriteLine("Answer is: "+calculator.MultiplyNumber(50, 10));
            Console.WriteLine("Answer is: " + calculator.DivisionNumber(50, 10));






            Console.ReadLine();
        }
    }
}
