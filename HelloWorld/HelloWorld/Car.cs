using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Car
    {
        public Car(uint doors, string color)
        {
            Wheels = 4;
            Doors = doors;
            Color = color;

            Tank = new GasTank(14.0);
        }

        ~Car()
        {
            Console.WriteLine("Noooo!");
        }

        public uint Wheels
        {
            get;
            private set;
        }

        public uint Doors
        {
            get;
            private set;
        }

        public string Color
        {
            get;
            private set;
        }

        public GasTank Tank
        {
            get;
            private set;
        }

        public Engine Engine
        {
            get;
            private set;
        }

        private double speed = 0;
        public double Speed
        {
            get { return speed; }
        }


        public void Go()
        {
            var gas = Tank.Consume(1.0);
            var accel = Engine.Combust(gas);
            speed += accel;
        }

        public void Stop()
        {
            speed = 0;
        }
    
    }
}
