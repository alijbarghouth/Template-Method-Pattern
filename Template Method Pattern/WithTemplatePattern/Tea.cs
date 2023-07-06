namespace Template_Method_Pattern.WithTemplatePattern
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping tea bag");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
