using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2.inhertance
{
    internal class parent
    {
        public parent(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x {  set; get; }
        public int y { set; get; }

        public override string ToString()
        {
            return $"{x} , {y}";
        }
        public  int prodct()
        {
            return x*y; 
        }

    }

  
}
