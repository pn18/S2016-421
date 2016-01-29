using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Engine
    {
        public double MaxRpm
        {
            get;
            private set;
        }

        private double rpm;

        public double Combust(double gas)
        {
            rpm += gas * 1000.0;
            if (rpm >= MaxRpm)
            {
                throw new Exception("Oh shit!");
            }

            return rpm / 5.0;
        }
    
    }
}
