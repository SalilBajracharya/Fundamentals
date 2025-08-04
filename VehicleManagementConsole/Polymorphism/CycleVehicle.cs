using VehicleManagementConsole.Models;

namespace VehicleManagementConsole.Polymorphism
{
    public class CycleVehicle : BaseVehicle
    {
        public override void Start()
        {
            Console.WriteLine($"Vehicle Id : {Id} // {Make} {Model}, {Year}. SingleSeated and doeesn't need to start. You just Pedal Pedal");
        }
    }
}
