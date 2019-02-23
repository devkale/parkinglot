using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotModels
{
    public abstract class Slot
    {
        public SlotStatus Status { get; set; }
        public int Number { get; set; }
        public Vehicle Vehicle { get; set; }
        public abstract void Park(Vehicle vehicle);
        public abstract void Vacate();
    }
    
}
