using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxtester
{

    public class calculations

    {
        private int _bol;
        public int Bol {
            get {
                return _bol * _bol + 74;
            }
            set {
                _bol = value;
            }
        }
        public int addNum(int a, int b)
        {
            return a + b;
        }
        public int sumNum(int a, int b)
        {
            return a - b;
        }
        public int carpNum(int a, int b)
        {
            return a * b;
        }
        public int bolNum(int a, int b)
        {
            return a / b;
        }
    } 


}
