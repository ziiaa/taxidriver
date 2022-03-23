using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxidriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Brigh";
            taxi.OnDuty = "Yes";
            taxi.NumPassenger = "10";

            taxi.Registrasi();
            taxi.Driver();



            Console.ReadKey();
        }
    }
}
