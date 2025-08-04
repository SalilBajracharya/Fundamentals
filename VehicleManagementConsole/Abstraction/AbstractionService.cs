namespace VehicleManagementConsole.Abstraction
{
    public static class AbstractionService
    {
        public static void RunAbstractionService()
        {
            Console.WriteLine("Running Abstraction Service...");
            PaymentMethod creditCardPayment = new CreditCardPayment();
            PaymentMethod qrPayment = new QRPayment();
            
            HandlePayment(creditCardPayment);
            HandlePayment(qrPayment);
        }

        public static void HandlePayment(PaymentMethod payment)
        {
            payment.ProcessPayment();
        }
    }
}
