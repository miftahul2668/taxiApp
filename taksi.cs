using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat object taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properties
            taxi.DriverName = "Miftahul";
            taxi.OnDuty = true;
            taxi.NumbOfPassenger = 2668;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOfPassenger();

            Console.ReadKey();
        }

    }
     class Taxi
    {
        public string driverName { get; set; }
        public bool onDuty { get; set; }
        public int NumPassenger { get; set; }
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name           : {0}", driverName);
            if (onDuty)
            {
                Console.WriteLine("On Duty              : Yes");
            }
            else
            {
                Console.WriteLine("On Duty              : No");
            }
            Console.WriteLine("Number of Passenger  : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            if (onDuty)
            {
                Console.WriteLine("Driver {0} sedang menjemput penumpang", driverName);
            }
            else
            {
                Console.WriteLine("Driver {0} tidak menjemput penumpang", driverName);
            }
        }
        public void DropOffPassenger()
        {
            if (onDuty)
            {
                Console.WriteLine("Driver {0} selesai mengantar penumpang", driverName);
            }
            else
            {
                Console.WriteLine("Driver {0} ", driverName);
            }
        }
    }

}