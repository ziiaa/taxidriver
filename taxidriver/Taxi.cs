using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxidriver
{
    public class Taxi
    {
        // Properties
        public string DriverName { get; set; }
        public string OnDuty { get; set; }
        public string NumPassenger { get; set; }

        // Method
        public void Registrasi()
        {
            Console.WriteLine("Nama Driver : {0}", DriverName);
            Console.WriteLine("Pick Up Passenger : {0}", OnDuty);
            Console.WriteLine("Drop Off Passenger : {0}", NumPassenger);
            Console.WriteLine("{0} Sedang Menjemput Penumpang\n",DriverName);
        }
        public void Driver()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang\n", DriverName);
        }
    }
}
