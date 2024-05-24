public class Order {

    private PaymentStrategy _paymentStrategy;

    public Order() {}
    public Order(PaymentStrategy paymentStrategy) {
        _paymentStrategy = paymentStrategy;
    }

    public void Checkout(string amount) {
        _paymentStrategy.Pay(amount);
    }

    public void SetPaymentStrategy(PaymentStrategy paymentStrategy) {
        _paymentStrategy = paymentStrategy;
    }

}