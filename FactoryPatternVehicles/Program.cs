using System;

namespace FactoryPatternVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWheels;
            bool input = false;
            do
            {
                Console.WriteLine("Building a new car...");



                input = int.TryParse(Console.ReadLine(), out numOfWheels);

            } while (!input == false);

            var vehicle = VehicleFactory.GetVehicle(numOfWheels);
            vehicle.Drive();            
        }
    }
}
