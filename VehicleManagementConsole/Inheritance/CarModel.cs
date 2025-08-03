namespace VehicleManagementConsole.Inheritance
{
    public class CarModel : BaseVehicalModel
    {
        public int NoOfDoors { get; set; }

        public override void Start()
        {
            Console.WriteLine($"Vehicle Id : {Id} // {Make} {Model} with {NoOfDoors} doors, {Year} is Starting vrrrrrr !!!!");
        }
    }
}
