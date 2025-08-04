namespace VehicleManagementConsole.Polymorphism
{
    public class BaseVehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool CarrierTF { get; set; }
        public virtual void Start()
        {
            Console.WriteLine($"Vehicle Id : {Id} // {Make} {Model}, {Year} is Starting vrrrrrr !!!!");
        }

        public virtual void HasCarrier()
        {
            if(CarrierTF)
                Console.WriteLine($"It has a carrier");
            else
                Console.WriteLine($"It is single seated");
        }
    }
}
