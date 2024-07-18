using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace demo2
{
    internal class car
    {

      /////////////old way /////////////////  
      /*  private int id;
        private string model;
        private double speed; 
        #endregion

        public int Id
        { get { return id; }
            set { id = value; }
        }*/

        public int id{ get; set; } 
        public string model { get; set; } 
        public string speed { get; set; } 

        public override string ToString()
        {
            return $"card id : {id} \n car model {model} \n car speed {speed} ";
        }
        public car(int id, string model, string speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;
        }
        public car()
        {
            Console.WriteLine("");
        }

        public car(int  ID ) : this(ID, "audi ", "400")
        {   
        }
        public car(int ID , string MODEL) :this(ID, MODEL, "300")
        {
     
        }

    }
}
