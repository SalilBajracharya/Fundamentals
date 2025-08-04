namespace VehicleManagementConsole.Polymorphism
{
    public static class PolymorphismService
    {
        public static void RunPolymorphismService()
        {
            Console.WriteLine("Running Polymorphism Service...");

            CycleVehicle cycle = new CycleVehicle
            {
                Id = 1,
                Make = "Hero",
                Model = "Sprint",
                Year = 2022,
                CarrierTF = false
            };

            cycle.Start();

            BikeVehicle bike = new BikeVehicle
            {
                Id = 2,
                Make = "Yamaha",
                Model = "FZ",
                Year = 2021,
                CarrierTF = true
            };

            bike.Start();
        }
    }
}
