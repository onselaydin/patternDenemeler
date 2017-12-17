using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class inheritanceDesign
    {
    }

    class Shape
    {

        public void setWidth(int w)
        {
            width = w;
        }

        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // Derived class
   class Rectangle : Shape
    {

        public int getArea()
        {
            return (width * height);
        }
    }



}
