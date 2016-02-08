using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Auto
{
    public static class Chevrolet
    {
        public static Car Malibu()
        {
            return new Car(4, "White");
        }

        public static Car Camaro
        {
            get { return new Car(2, "Yellow"); }
        }
    
    
    }
}
