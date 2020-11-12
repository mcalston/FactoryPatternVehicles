using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternVehicles
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {

        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The motorcycle is reving up!");
            Console.WriteLine("Go vrooom");
        }
    }
       
}
