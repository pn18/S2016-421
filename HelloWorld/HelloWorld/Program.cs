using System;

namespace HelloWorld
{

    class Car
    {
        public Car()
        {
        }

        uint Wheels;
        uint Doors;
        string Color;

        void Go()
        {
            Console.WriteLine("Ok");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var car = new HelloWorld.Car();

            string str = "Hello";
            str = str.Insert(0, "World");
            Console.WriteLine(str);
        }
    }
}
