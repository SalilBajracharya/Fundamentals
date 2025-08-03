namespace VehicleManagementConsole.Inheritance
{
    public class BaseVehicalModel
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        private int _year;
        public int Year
        {
            get => _year;
            set
            {
                if (value < 1000 || value > DateTime.Now.Year)
                    throw new ArgumentException("Year must be a valid year and not more than current year.");

                _year = value;
            }
        }

        public virtual void Start() {
            Console.WriteLine($"Vehicle Id : {Id} // {Make} {Model}, {Year} is Starting vrrrrrr !!!!");
        }

    }
}
