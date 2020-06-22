using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1706
{
    class Car : Vehicle
    {
        public int _numberOfDoors;
        public override int GetMaxNumOfPassengers()
        {
            return 4;
        }

        public override int GetMaxSpeed()
        {
            return 300;
        }

        public override string ToString()
        {
            return $"Doors number: {_numberOfDoors} {base.ToString()}";
        }
    }
}
