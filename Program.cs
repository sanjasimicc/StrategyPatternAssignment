public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Insert desired amount you would like to pay: ");
        var amount = Console.ReadLine();
     
        Console.WriteLine("Choose a payment method:");
        Console.WriteLine("1. Credit Card");
        Console.WriteLine("2. PayPal");
        Console.WriteLine("3. Bitcoin");
        Console.WriteLine("4. Bank Transfer");

        var choice = Console.ReadLine();

        PaymentStrategy paymentStrategy;

        switch (choice) {
            case "1":
                paymentStrategy = new CreditCardPayment();
                Console.WriteLine("Client: Strategy is set to credit card payment.");
                break;
            case "2":
                paymentStrategy = new PayPalPayment();
                Console.WriteLine("Client: Strategy is set to PayPal payment.");
                break;
            case "3":
                paymentStrategy = new CryptoPayment();
                Console.WriteLine("Client: Strategy is set to Crypto payment.");
                break;
            case "4":
                paymentStrategy = new BankTransferPayment();
                Console.WriteLine("Client: Strategy is set to bank transfer payment.");
                break;
            default:
                Console.WriteLine("Invalid choice. Defaulting to credit card payment.");
                paymentStrategy = new CreditCardPayment();
                break;
        }

        var order = new Order();
        order.SetPaymentStrategy(paymentStrategy);
        order.Checkout(amount);
    }
}