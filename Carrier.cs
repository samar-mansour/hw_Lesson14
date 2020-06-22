using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1706
{
    class Carrier
    {
       public Vehicle [] _vehicle;

        public override string ToString()
        {
            string result = $"Vehicles number: {_vehicle.Length}\n";

            for (int i = 0; i < _vehicle.Length; i++)
            {
                result = result + _vehicle[i].ToString() + "\n";
            }
            return result;
        }
    }
}
