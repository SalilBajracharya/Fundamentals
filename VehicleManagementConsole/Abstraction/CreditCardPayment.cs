namespace VehicleManagementConsole.Abstraction
{
    public class CreditCardPayment : PaymentMethod
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }
}
