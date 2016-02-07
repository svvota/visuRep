using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
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
    class trcaDeneme
    //{
    //    try{int a =5;int b = 10;int c = a + b;  }
    //    catch{}
    }
}
