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

        }

        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

        }
    }
}