namespace VehicleManagementConsole.Encapsulation
{
    public class EncapsulatedVehicle
    {
        private readonly int _id;
        private string _make;
        private string _model;
        private int _speed;

        public EncapsulatedVehicle(int id)
        {
            _id = id;
        }

        public EncapsulatedVehicle(int id, string make, string model, int speed)
        {
            _id = id;
            Make = make;
            Model = model;
            Speed = speed;
        }

        public string Make
        {
            get => _make;
            set => _make = value;
        }
        public string Model {
            get => _model;
            set => _model = value;
        }
        public int Speed
        {
            get { return _speed; }
            set 
            { 
                if (value < 0)
                    throw new ArgumentException("Speed cannot be negative.");
                _speed = value;
            }
        }

        public override string ToString()
        {
            return $"[Encapsulation Id: {_id}] Make: {Make}, Model: {Model}, Speed: {Speed} km/h" ;
        }
    }
}
