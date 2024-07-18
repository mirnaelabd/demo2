using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    internal struct phonebook
    {

        #region attribute 
        private string[] names;
        private int[] numbers;

        #endregion

        #region properties
        public int Size
        {
            get;
        }

        #endregion


        #region  constructor 
        public phonebook(int size)
        {

            Size = size;
            names = new string[size];
            numbers = new int[size];
        }
        #endregion 
        #region method 
        public void Addperson(int position, string name, int phonenumber)
        {
            if (names is not null && numbers is not null)
            {
                if (position < Size)
                {
                    names[position] = name;
                    numbers[position] = phonenumber;
                }
            }


        }




        #endregion

        public int this[string name]
        {
            get
            {
                if (names is not null && numbers is not null)

                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                            return numbers[i];
                    }
                return -1;


            }
            set
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                        if (names[i] == name)
                        {
                            numbers[i] = value;
                            break;
                        }

                }
            }
        }
        public string this [int index]
            {
            get {
                return $"{index} :: {names[index]} :: {numbers[index]}";
            }
           }
    }
}
    

