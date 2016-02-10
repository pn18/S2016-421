using System;
using Oops;

//using Oops.Auto;

namespace HelloWorld
{
    class Program
    {
        //static void Car()
        //{
        //    //var car = Oops.Auto.Chevrolet.Malibu();
        //    //var car = Oops.Auto.Chevrolet.Camaro;

        //    try
        //    {
        //        car.Go();
        //        car.Go();
        //        car.Go();
        //        car.Go();
        //        car.Go();
        //        car.Go();
        //        car.Go();
        //        car.Go();
        //        car.Go();
        //        car.Go();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine(car.Speed);
        //        Console.WriteLine(car.Engine.Rpm);
        //        Console.WriteLine(car.Tank.Volume);

        //        Console.WriteLine("Ok");
        //    }
        //    finally
        //    {
        //        car.Stop();
        //    }
        //}


        static void Music()
        {
            object device = new Oops.Music.Mp3Player();
            object device2 = new Oops.Music.Mp3Player();

            var text = device.ToString();
        }
    

        static void Main(string[] args)
        {
            Music();

        }
    }
}
