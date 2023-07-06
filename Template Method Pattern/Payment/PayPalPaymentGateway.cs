namespace Template_Method_Pattern.Payment;

public class PayPalPaymentGateway : PaymentGateway
{
    protected override void ValidatePayment()
    {
        throw new NotImplementedException();
    }

    protected override void TransferMoney()
    {
        throw new NotImplementedException();
    }

    protected override void UpdateDatabase()
    {
        throw new NotImplementedException();
    }
}