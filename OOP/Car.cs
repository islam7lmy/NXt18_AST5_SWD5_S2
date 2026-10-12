using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        /// Attributes or Fields
        //public int Id;
        //public string Model; 
        //public int Speed;

        public int Id { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        //private string _model;

        //public string ModelFull
        //{
        //    get { return _model; }
        //    set { _model = value.Length <=20 ? value : value.Substring(0,20); }
        //}


        public Car(int _id, string _model, int _speed)
        {
            Id = _id;
            Model = _model;
            Speed = _speed;
            Console.WriteLine("Ctor 04");
        }

        public Car(int _id, string _model) : this(_id,_model,320)
        {
            //Id = _id;
            //Model = _model;
            //Speed = 320;
            Console.WriteLine("Ctor 03");
        }

        public Car(int _id) : this(_id , "BMW")
        {
            //Id = _id;
            //Model = "BMW";
            //Speed = 320;
            Console.WriteLine("Ctor 02");
        }

        public Car() : this(10)
        {
            //Id = 10;
            //Model = "BMW";
            //Speed = 320;
            Console.WriteLine("Ctor 01");
        }
    }
}
