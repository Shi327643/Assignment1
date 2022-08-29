using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Rectangle class from library");

            Rectangle rectangle = new Rectangle();
            rectangle.Length = 10;
            rectangle.Width = 20;
            Console.WriteLine(rectangle);

            Console.WriteLine("Area of rectangle is:-" + rectangle.GetArea());
            

            Console.ReadLine();
        }
    }
}
