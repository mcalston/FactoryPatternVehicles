using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternVehicles
{
    public class ThreeWheeler : IVehicle
    { 
    public ThreeWheeler()
        {

        }
    public void Drive()
    {
        ConsoleLogger.VehicleStartUpDialogue();
        Console.WriteLine("Let's goo!");
    }
}
}

