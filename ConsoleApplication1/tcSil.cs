using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxtester
{
    class tcSil
    {
        private int _height;
        public int Height {
            get
            {
                return _height;
            }
            set
            {
                this._height = 3;
            }

        }
        public string Color { get; set; }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
    public class trcaDeneme
    {
        public void arrLi() {

            try {
                int[] arri = new int[2];
                arri[0] = 1;
                arri[1] = 2;
                arri[2] = 3;
            }
            catch (Exception ex) {
                Console.WriteLine("Burda hata var");
            }

        }
   
    }
}
