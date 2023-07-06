using Template_Method_Pattern.Payment;
using Template_Method_Pattern.TemplatePatternWithHooks;
using Template_Method_Pattern.WithoutTemplatePattern;
using Template_Method_Pattern.WithTemplatePattern;

namespace Template_Method_Pattern
{
    public class Program
    {
        private static void Main()
        {
            var tea = new Tea1();
            var coffee = new Coffee1();
            coffee.PrepareRecipe();

            Console.ReadLine();
            string repeatedString = new string('*', 40);
            Console.WriteLine(repeatedString);

            CaffeineBeverage caffeineBeverage = new Coffee();
            caffeineBeverage.PrepareRecipe();

            Console.ReadLine();
            Console.WriteLine(repeatedString);

            CaffeineBeverageWithHooks withHooks = new CoffeeWithHooks();
            withHooks.PrepareRecipe();

            Console.ReadLine();
            Console.WriteLine(repeatedString);

            PaymentGatewayFactory factory = new PaymentGatewayFactory();
            PaymentGateway gateway = factory.GetPaymentGateway("credit card");
            gateway.MakePayment();
        }
    }
}