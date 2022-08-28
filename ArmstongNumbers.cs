using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSolutions
{
    internal class ArmstongNumbers
    {
        static void Main(string[] args)
        {
            int number, rem, sum, store;
            Console.WriteLine("Print all the Armstrong numbers from 1 to 1000");
            for (number = 1; number <= 1000; number++)
            {
                sum = 0;
                store = number;
                while (store != 0)
                {
                    rem = store % 10; ;
                    sum = sum + (rem * rem * rem);
                    store = store / 10;
                }
                if (sum == number)
                {
                    Console.WriteLine(number);


                }

            }
            Console.ReadLine();
        }
    }
}
