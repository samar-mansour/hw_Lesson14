using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1706
{
    abstract class Vehicle
    {
        public int _numberOfWheels;
        public string _model;

        public abstract int GetMaxNumOfPassengers();
        public abstract int GetMaxSpeed();

        public override string ToString()
        {
            return $"Model: {_model} Number of wheels: {_numberOfWheels} Passenger seats: {GetMaxNumOfPassengers()} Max speed: {GetMaxSpeed()} ";
        }
    }
}
