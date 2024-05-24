public class BankTransferPayment : PaymentStrategy
{
    public void Pay(string amount)
    {
        Console.WriteLine($"Payment amount via bank transfer is {amount}");
    }
}