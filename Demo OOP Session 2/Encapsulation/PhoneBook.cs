using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_Session_2.Encapsulation
{
    internal struct PhoneBook
    {
        #region fields

        private string[] names;
        private string[] numbers;
        private int size;

        #endregion

        public long getnumber(string name)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (names[i] == name)
                    {
                        return (long) numbers[i];
                    }
                    return -1;
                }
            }

                
                    
             

        #region Properties

        public int Size
        {
            get { return Size; }
        }
        #endregion

        #region Constructors
        public PhoneBook(int size)
        {
            this.Size = size;
            names = new string[size];
            numbers = new string[size];
        }
        #endregion

        #region Methods
        public void AddPerson(uint Position,string name, ulong number)
        {
            if(names is not null && numbers not null && Position < size)
            {
                names[Position] = name;
                numbers[Position] = number;
            }
        }
        #endregion
    }
}
