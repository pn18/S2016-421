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

            try
            {
                car.Go();
                car.Go();
                car.Go();
                car.Go();
                car.Go();
                car.Go();
                car.Go();
                car.Go();
                car.Go();
                car.Go();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(car.Speed);
                Console.WriteLine(car.Engine.Rpm);
                Console.WriteLine(car.Tank.Volume);

                Console.WriteLine("Ok");
            }
            finally
            {
                car.Stop();
            }


        }
    }
}
