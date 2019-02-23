using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotModels
{
    public class GeneralSlot : Slot
    {

        public GeneralSlot(int number)
        {
            Status = SlotStatus.Avaialable;
            Number = number;
        }

        public override void Park(Vehicle vehicle)
        {
            Status = SlotStatus.Occupied;
            Vehicle = vehicle;
            //Console.Out.WriteLine("Allocated slot number: {0}", Number);
        }

        public override void Vacate()
        {
            Status = SlotStatus.Avaialable;
            Vehicle = null;
            //Console.Out.WriteLine("Slot number {0} is freed", Number);
        }
    }
}
