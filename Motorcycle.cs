using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1706
{
    class Motorcycle : Vehicle
    {
        public int _numberofHandBreakes;
        public override int GetMaxNumOfPassengers()
        {
            return 2;
        }

        public override int GetMaxSpeed()
        {
            return 280;
        }

        public override string ToString()
        {
            return $"Hand Breaks: {_numberofHandBreakes} {base.ToString()}";
        }
    }
}
