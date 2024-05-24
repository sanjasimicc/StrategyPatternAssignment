public class CryptoPayment : PaymentStrategy
{
    public void Pay(string amount)
    {
        Console.WriteLine($"Payment amount via Crypto payment is {amount}");
    }
}