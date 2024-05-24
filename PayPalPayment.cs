public class PayPalPayment : PaymentStrategy
{
    public void Pay(string amount)
    {
        Console.WriteLine($"Payment amount via Pay Pal is {amount}");
    }
}