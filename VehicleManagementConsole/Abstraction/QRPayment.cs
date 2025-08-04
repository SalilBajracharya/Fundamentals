namespace VehicleManagementConsole.Abstraction
{
    public class QRPayment : PaymentMethod
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing QR payment...");
        }
    }
}
