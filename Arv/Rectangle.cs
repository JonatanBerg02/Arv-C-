using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Rectangle : Shape
    {
        public Rectangle(int height, int width) : base(height, width) { }
        public int RecArea()
        {
            int recArea = Height * width;
            return recArea;

        }
       public int RecCircumferance()
        {
            int recCircumferance = Height * 2 + width * 2;
            return recCircumferance;
        }

    }
}
