using System.Runtime.InteropServices;

namespace Template_Method_Pattern.Payment;

public class PaymentGatewayFactory
{
    public PaymentGateway GetPaymentGateway(String paymentOption)
    {
        if (paymentOption.Equals("credit card"))
        {
            return new CreditCardPaymentGateway();
        }
        else if (paymentOption.Equals("paypal"))
        {
            return new PayPalPaymentGateway();
        }
        else
        {
            throw new InvalidOleVariantTypeException("Invalid payment option");
        }
    }
}