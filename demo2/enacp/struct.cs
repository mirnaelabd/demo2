using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2.enacp
{
    internal struct employee
    {
        #region attruibutes
        public int id;
        private string? empname;
        public decimal salary;
        private int age;

        public employee(int id, string? empname, decimal salary, int age) : this()
        {
            this.id = id;
            this.empname = empname;
            this.salary = salary;
            this.age = age;
        }


        #endregion 
        // encapsulation  separate data defintion [attribute ] from it use {getter , setter , property }
        #region using getter & setter 
        // a- attributes private 
        //b- 2 function getter & setter 

        // getter 
        public string? getname()
         { return empname; }


        //setter
        public void setname(string? value)
        {
            
            empname= value?.Length>5 ? value.Substring(0,5):value;
        }
        #endregion
        #region propert 
        //properties [full - automatic , indexer )
        //private attributes 
        // property 
        public decimal Salary
        {
            get { return salary; }
            set { salary = value < 5000 ? 5000 : value; }
        }
        public decimal deduction
        {

            get { return salary * 0.2M; }
            
         }
    /*    public int Age
        {
            get { return age; }
            set { age = value; }
        }*/
            // compiler will generate hidden private attribute [ backing field ] 
        public int Age { get; set; }
        #endregion

    

        #region override
        public override string ToString()
        {
            return ($"ID : {id} \n name : {empname} \n salary = {salary:c}");
        }
        #endregion

    }
}
