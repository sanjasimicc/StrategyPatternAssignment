public class CreditCardPayment : PaymentStrategy
{
    public void Pay(string amount)
    {
        Console.WriteLine($"Payment amount via credit card is {amount}");
    }
}