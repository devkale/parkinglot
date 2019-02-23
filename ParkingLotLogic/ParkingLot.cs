using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingLotModels;
namespace ParkingLotLogic
{
    
    public class ParkingLot
    {
        private static ParkingLot parkingLot = null;
        private List<Slot> slots; 

        private int NumberOfSlots;

        private ParkingLot(int numberOfslots)
        {
            NumberOfSlots = numberOfslots;
            slots = new List<Slot>();
            for (int i = 1 ; i <= numberOfslots;i++)
            {
                slots.Add(new GeneralSlot(i));
            }
            Console.Out.WriteLine("Create a parking lot with " + numberOfslots + " slots");
        }

        public static ParkingLot GetInstance(int numberOfslots)
        {
            if (parkingLot == null)
            {
                parkingLot = new ParkingLot(numberOfslots);
            }
            return parkingLot;
        }

        public List<Slot> GetStatusOfAllocatedSlots()
        {
            return slots.FindAll(x => x.Status == SlotStatus.Occupied);
        }
        public List<Slot> GetStatusOfAvailableSlots()
        {
            return slots.FindAll(x => x.Status == SlotStatus.Avaialable);
        }

        public void Park(Vehicle vehicle)
        {
            Slot slot = slots.Find(x => x.Status == SlotStatus.Avaialable);
            if(slot == null)
            {
                Console.Out.WriteLine("Sorry parking lot is full");
                return;
            }
            //slot.Status = SlotStatus.Occupied;
            //slot.Car = car;
            //Console.Out.WriteLine("Allocated slot number: {0}", slot.Number);

            slot.Park(vehicle);
            Console.Out.WriteLine("Allocated slot number: {0}", slot.Number);
        }

        public void Vacate(int slotNumber)
        {
            Slot slot = slots.Find(x => (x.Number == slotNumber && x.Status == SlotStatus.Occupied));
            if(slot == null)
            {
                Console.Out.WriteLine("Sorry slot is already vacant or does not exist");
                return;
            }
            //slot.Status = SlotStatus.Avaialable;
            //slot.Car = null;
            //Console.Out.WriteLine("Slot number {0} is freed", slot.Number);
            slot.Vacate();
            Console.Out.WriteLine("Slot number {0} is freed", slot.Number);
        }
    }


}
