using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxtester
{
    class boxT
    {
        private double weight;   // Height of a box
        public double getWeight()
        {
            return weight + weight + weight + weight;
        }
        public void setWeight(double wei)
        {
            weight = wei;
        }

        public void boxThings(double length,double breadth,double height)
        {

            double volume = 0.0;    // Store the volume of a box here

            // box 1 specification
            //height = 5.0;
            //length = 6.0;
            //breadth = 7.0;

            //// box 2 specification
            //height = 10.0;
            //length = 12.0;
            //breadth = 13.0;

            // volume of box 1
            //volume = height * length * breadth;
            //Console.WriteLine("Kutunun hacmi : {0}", volume);

            // volume of box 2
            volume = height * length * breadth;
            Console.WriteLine("");
            Console.WriteLine("Kutunun hacmi : {0}", volume);
        }

    }
}
