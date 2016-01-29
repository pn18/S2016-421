using System;
using Oops;
using Oops.Foo;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(2, "Red");
            car.Go();
            car.Stop();
        }
    }
}
