using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class GasTank
    {
        public GasTank(double capacity)
        {
            Capacity = capacity;
        }

        public double Capacity
        {
            get;
            private set;
        }

        private double volume;
        public double Volume
        {
            get { return volume; }
        }

        public bool Warning
        {
            get { return volume <= 1.0; }
        }

        public double Consume(double amount)
        {
            amount = Math.Min(volume, amount);
            volume -= amount;
            return amount;
        }
    }
}
