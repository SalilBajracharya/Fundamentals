namespace VehicleManagementConsole.Polymorphism
{
    public class BikeVehicle : BaseVehicle
    {
        public override void HasCarrier()
        {
            base.HasCarrier(); //basically just calls the method from base Class and nothing more.
        }
    }
}
