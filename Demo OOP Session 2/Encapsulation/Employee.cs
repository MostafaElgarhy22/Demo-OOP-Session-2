using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_Session_2.Encapsulation
{
   
    internal struct Employee
    {
        //*** Encapsulation : Separating DataDefinition from its Use[Gettres & Setters]

        #region Attributes
        private int id;
        private string name;
        private decimal salary;

        #endregion


        #region//1. Encapsulation through Getters and Setters [Old Approach]

        // Getters
        public int GetId()
        {
            return id;
        }
        // Setters
        public void SetId(int Value)
        {
            id = Value > 1000 && Value < 10000 ? Value : 9999; // Data Validation
        }
        #endregion

        #region //2. Encapsulation through Propeties [New Approach] // Recommended

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion


        #region Constructors
        public Employee(int id, string name, decimal salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id: {id}, Name: {name}, Salary: {salary}";
        }
        #endregion
    }
}
