using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingLotLogic;
using ParkingLotModels;
namespace ParkingLotRunner
{
    class ParkingLotRunner
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = ParkingLot.GetInstance(6);
            List<Slot> slots = null;
            Vehicle car1 = new Car() { RegistrationNumber = "01-1234", Color = Color.White};
            parkingLot.Park(car1);

            Vehicle car2 = new Car() { RegistrationNumber = "01-9999", Color = Color.White };
            parkingLot.Park(car2);
            Vehicle car3 = new Car() { RegistrationNumber = "01-0001", Color = Color.Black };
            parkingLot.Park(car3);
            Vehicle car4 = new Car() { RegistrationNumber = "01-7777", Color = Color.Red };
            parkingLot.Park(car4);
            Vehicle car5 = new Car() { RegistrationNumber = "01-2701", Color = Color.Blue };
            parkingLot.Park(car5);
            Vehicle car6 = new Car() { RegistrationNumber = "01-3141", Color = Color.Black };
            parkingLot.Park(car6);
            parkingLot.Vacate(4);



            slots = parkingLot.GetStatusOfAllocatedSlots();
            Console.Out.WriteLine("Slot No \t Registration \t Color");
            foreach(var slot in slots)
            {
                Console.Out.WriteLine("{0}\t{1}\t{2}", slot.Number, slot.Vehicle.RegistrationNumber, slot.Vehicle.Color);
            }

            
            slots = parkingLot.GetStatusOfAvailableSlots();
            Console.Out.WriteLine("Slots");
            foreach (var slot in slots)
            {
                Console.Out.WriteLine("{0}", slot.Number);
            }
            Vehicle car7 = new Car() { RegistrationNumber = "01-333", Color = Color.White };
            parkingLot.Park(car7);
            Vehicle car8 = new Car() { RegistrationNumber = "12-9999", Color = Color.White };
            parkingLot.Park(car8);


            Console.In.Read();
        }

        public static void PrintParkingMessage(GeneralSlot slot)
        {
            if (slot == null)
            {
                Console.Out.WriteLine("Sorry parking lot is full");
                return;
            }
            else
            {
                Console.Out.WriteLine("Allocated slot number: {0}", slot.Number);
            }
        }
    }
}
