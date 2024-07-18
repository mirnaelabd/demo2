using demo2.enacp;
using System.IO;
using System;
using System.Security.Cryptography;
using demo2.inhertance;

namespace demo2
{
    internal class Program
    {
        static void Main()
        {
            #region encap
            /*employee employee = new employee(10, "aliaa", 2000, 3);

                Console.WriteLine(employee);
                employee.id = 20; // set id directly through attribute 
                Console.WriteLine(employee.id); //get id directly through attribute
                employee.setname("mona");
                Console.WriteLine(employee.getname());
                employee.Salary = 5000;// set salary property 
                Console.WriteLine(employee.Salary);

                Console.WriteLine(employee);
                Console.WriteLine(employee.deduction);
    */


            #endregion
            #region encap 
            phonebook note = new phonebook(3);
            note.Addperson(1, "mona", 4334);
            note.Addperson(2, "ahmed", 45656);
            note.Addperson(3, "mirna", 4332324);
            Console.WriteLine(note["mona"]);
            note["mona"] = 666;
            Console.WriteLine(note["mona"]);

            for (int i = 0; i < note.Size; i++)
            {
                Console.WriteLine(note[i]);
            }
            #endregion
            #region class
            /*          car c1;
                      c1 = new car(10, "bmw", "290");

                      car c2 = new car(10);
                      Console.WriteLine(c1);
                      Console.WriteLine("///////////////////////////");
                      Console.WriteLine(c2);
                      car c3 = new car(10, "bmw");
                      Console.WriteLine("///////////////////////////");
                      Console.WriteLine(c3);*/
            #endregion
            #region inhertance 
            /*      parent p = new parent(1,2);
                  Console.WriteLine(p);
                  Console.WriteLine(p.prodct());
                  child x = new child(1, 2 ,3);
                  Console.WriteLine(x);
                  Console.WriteLine(x.prodct());*/
            #endregion




        }
    }
}
