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
        

        /// <summary>
        /// Property with custom value when null.
        /// </summary>
        static string Name
        {
            get
            {
                return _name ?? "Default";
            }
            set
            {
                _name = value;
            }
        }
        static string _name;
        protected int height;
        protected int width;
        protected string color;

    }
    class Kare : Shape{

        public int kareAlan() {
            return width * height;
        }

    }
    class Yuzey : Kare {

        public int Yuzeysel() {
            return (width + height)*2;

        }
    }
}
