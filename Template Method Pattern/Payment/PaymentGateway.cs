namespace Template_Method_Pattern.Payment
{

    public abstract class PaymentGateway
    {
        public void MakePayment()
        {
            ValidatePayment();
            TransferMoney();
            UpdateDatabase();
        }
        protected abstract void ValidatePayment();
        protected abstract void TransferMoney();
        protected abstract void UpdateDatabase();
    }
}