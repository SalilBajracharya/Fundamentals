namespace VehicleManagementConsole.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Speed { get; set; }

        public override string ToString()
        {
            return $"[Classes&Object Id: {Id}] {Make} {Model}";
        }
    }


}
