using VehicleManagementConsole.Models;

namespace VehicleManagementConsole._1._ClassAndObjects
{
    public static class ClassesAndObjectServices
    {
        public static void RunClassesAndObjectServices()
        {
            Console.WriteLine("Running Classes & Object Service...");

            var vehicle1 = new VehicleModel
            {
                Id = 1,
                Make = "Toyota",
                Model = "Corolla",
                Speed = "120 km/h"
            };

            var vehicle2 = new VehicleModel
            {
                Id = 2,
                Make = "Honda",
                Model = "Civic",
                Speed = "130 km/h"
            };

            Console.WriteLine(vehicle1);
            Console.WriteLine(vehicle2);
        }
    }
}
