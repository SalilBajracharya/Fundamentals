namespace VehicleManagementConsole.Inheritance
{
    public static class InheritanceService
    {
        public static void RunInheritanceService()
        {
            Console.WriteLine("Running Inheritance Service...");
            
            CarModel car = new CarModel
            {
                Id = 1,
                Make = "Toyota",
                Model = "Corolla",
                Year = 2020,
                NoOfDoors = 4
            };
            
            car.Start();
        }
    }
}
