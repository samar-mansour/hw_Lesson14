using oop1706;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hw_oop_Lesson14
{
    class Program
    {
        static void PrintVehicle(Vehicle v)
        {
            Console.WriteLine(v._model);
        }

        static void PrintVehicleArray(Vehicle [] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
        }
        static void Main(string[] args)
        {
            Car rangRover = new Car()
            {
                _model = "Sport",
                _numberOfDoors = 4,
                _numberOfWheels = 4
            };

            Car audi = new Car()
            {
                _model = "R8 V10 plus",
                _numberOfDoors = 2,
                _numberOfWheels = 4
            };

            Motorcycle triumph = new Motorcycle()
            {
                _model = "Rocket 3 GT",
                _numberOfWheels = 2,
                _numberofHandBreakes = 2
            };

            Motorcycle kawasaki = new Motorcycle()
            {
                _model = "NINJA H2R",
                _numberOfWheels = 2,
                _numberofHandBreakes = 2
            };

            Console.WriteLine("=========Vehicle Model==========");
            PrintVehicle(audi);
            PrintVehicle(kawasaki);

            Vehicle[] myVehicles = new Vehicle[3]
            {
                 new Motorcycle()
                 {
                    _model = "NINJA 1000SX",
                    _numberOfWheels = 2,
                    _numberofHandBreakes = 1
                 },

                 new Car()
                 {
                    _model = "Mclaren 600LT",
                    _numberOfDoors = 2,
                    _numberOfWheels = 4
                 },

                 new Car()
                 {
                    _model = "Sián FKP 37",
                    _numberOfDoors = 2,
                    _numberOfWheels = 4
                 }
            };

            Console.WriteLine("=========Vehicle Array==========");
            PrintVehicleArray(myVehicles);
            Console.WriteLine("=========Print Model Vehicle Array==========");
            PrintVehicle(myVehicles[2]);


            Carrier carrier = new Carrier()
            {
                _vehicle = new Vehicle[]
                {
                    new Car
                    {
                        _model = "TT",
                        _numberOfDoors = 2,
                        _numberOfWheels = 4
                    },

                    new Motorcycle
                    {
                        _model = "Honda CRF",
                        _numberOfWheels = 2,
                        _numberofHandBreakes = 1
                    }
                }
            };
            Console.WriteLine("========Carrier=========");
            Console.WriteLine(carrier);
        }
    }
}
