using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2.inhertance
{
    internal class child : parent  //
    {
        public int z {  get; set; }
        public child(int x , int y , int z):base( x,y)
        {
            this.z = z;
        }
        public override string ToString()
        {
            return $"{x} , {y} , {z}";
        }
        public new int prodct()
        {
            /*  return x*y*z;*/
            return base.prodct() * z;
        }


    }
}
