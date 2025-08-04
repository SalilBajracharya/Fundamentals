namespace VehicleManagementConsole.Encapsulation
{
    public static class EncapsulatedService
    {
        public static void RunEncapsulatedService()
        {
            Console.WriteLine("Running Encapsulation Service...");

            var encapsulatedVehicle = new EncapsulatedVehicle(1)
            {
                Make = "Toyota",
                Model = "Corolla",
                Speed = 120
            };

            var encapsulatedVehicle1 = new EncapsulatedVehicle(2, "Honda", "Civic", 130);

            Console.WriteLine(encapsulatedVehicle);
            Console.WriteLine(encapsulatedVehicle1);

        }

    }
}
