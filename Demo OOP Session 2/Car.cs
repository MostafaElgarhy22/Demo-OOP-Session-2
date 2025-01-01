using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_Session_2
{
    internal class Car
    {
        #region Attributes
        private int _id;
        private string? _model;
        private Double speed;
        #endregion

        #region Properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string? Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public Double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id: {Id}, Model: {Model}, Speed: {Speed}";
        }
        #endregion

        public Car(int id)
        {
            Id = id;
            Model = "Hyundai";
            Speed = 220;
        }

        public Car(int id , string? model) : this (id, model , 120) 
        {
            //Id = id;
            //Model = model;
            //Speed = 160;

            Console.WriteLine("Constructor 02");
        }



}
