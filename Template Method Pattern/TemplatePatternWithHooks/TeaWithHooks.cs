namespace Template_Method_Pattern.TemplatePatternWithHooks
{
    public class TeaWithHooks : CaffeineBeverageWithHooks
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
