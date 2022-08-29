using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Rectangle
    {
        private int length; // field

        public int Length // property
        {
            get { return length; }  
            set { length = value; }
        }

        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int GetArea()
        {
            return length * width;
        }

        public override string ToString()
        {
            return String.Format($"Length : {Length} Width = {Width}");
        }
    }
}
