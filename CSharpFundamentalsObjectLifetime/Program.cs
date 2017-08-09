using System;

namespace CSharpFundamentalsObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
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