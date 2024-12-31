using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_Session_2
{
    internal struct Point
    {
        #region Fields
        // Attributes
        private int x;
        private int y;
        #endregion
        #region Comments
        // Constructor : is a special Function
        //              1. Name is the same as the class name
        //              2. No return type


        // in Struct, we can't have a parameterless constructor
        // This Constructor is called when we create an object of type Point

        //public Point()
        //{
        //    x = default;
        //    y = default;
        //}
        #endregion




        public Point()
        {
            x = default;
            y = default;
        }


        public Point(int x, int y)    // it can't be private
        {
            this.x = x;
            this.y = y;
        }

        public Point(int Number)
        {
            this.x = this.y = Number;
        }
        #region Methods
        public override string ToString()
        {
            return $"({x}, {y})";
        }
        #endregion
    }
}
