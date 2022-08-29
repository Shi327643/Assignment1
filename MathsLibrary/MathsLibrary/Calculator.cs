using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public class Calculator
    {
        private int number1;

        public int Number1
        {
            get { return number1; } 
            set { number1 = value; }

        }

        private int number2;

        public int Number2
        {
            get { return number2; }
            set { number2 = value; }

        }


        public int AddNumber(int number1, int number2)
        {
            int Ans = number1 + number2;    
            return Ans;
        }
        public int SubtractNumber(int number1, int number2)
        {
            int Ans = number1 - number2;
            return Ans;
        }
        public int MultiplyNumber(int number1, int number2)
        {
            int Ans = number1 * number2;
            return Ans;
        }
        public int DivisionNumber(int number1, int number2)
        {
            int Ans = number1 / number2;
            return Ans;
        }

        public override string ToString()
        {
            return String.Format($"Number1 : {Number1} Number2 : {Number2}");
        }


    }
}
