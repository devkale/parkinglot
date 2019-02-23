using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotModels
{
    public abstract class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public Color Color { get; set; }
    }
}
