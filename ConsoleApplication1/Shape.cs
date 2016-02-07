using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxtester
{
    class Shape
    {

        public void setWidth(int wid) {
            width = wid;
        }
        public int getWidth()
        {
            return width;
        }
        public void setHeight(int hei)
        {
            height = hei;
        }
        public int getHeight()
        {
            return height;
        }
        public void setColor(string col)
        {
            color = col;
        }
        public string getColor()
        {
            return color;
        }
        protected int height;
        protected int width;
        protected string color;

    }
    class Kare : Shape{

        public int kareAlan() {
            return width * height;
        }

    }
}
