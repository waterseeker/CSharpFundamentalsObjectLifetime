using System;

namespace CSharpFundamentalsObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a new instance of a car
            //and sets the var myCar as a reference to the object's location in memory
            Car myCar = new Car();

            //this just points to the same spot in memory, 
            //not another instance of a Car. Reference type vs. Value type. 
            Car myOtherCar = myCar;

            //removes references to that spot in memory
            //at some point the garbage collection in C#
            //will check to see if there are any objects in memory
            //that have no references pointing at them. 
            //If it finds any objects with no references it will delete them. 
            myOtherCar = null;
            myCar = null;

            Car myThirdCar = new Car(); //using the default constructor
            Car myOverloadedCar = new Car("Honda", "Del Sol", 1997, "Black"); //using the overloaded constructor
        }

        class Car
        {
            //these are the props of the object
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }
            public double OriginalPrice { get; set; }


            //this is a constructor. you can use it to set the object to a valid state
            //as soon as it is created, setting default values for props, etc. 
            public Car() 
            {
                //you could load this from a configuration file, a database, etc.
                //we are just hardcoding this for the example.
                this.Make = "Nissan"; //by default, every new Car is a Nissan. 
            }

            //this is an overloaded method for the constructor. 
            public Car(string make, string model, int year, string color)
            {
                Make = make;
                Model = model;
                Year = year;
                Color = color;
            }

            //param names don't affect the method signature. the method below will cause an error
            //because it has the same signature as the overloaded constructor does. 
            //public Car(string otherMake, string model, int year, string color)
            //{
            //    Make = otherMake;
            //    Model = model;
            //    Year = year;
            //    Color = color;
            //}
        }
    }
}