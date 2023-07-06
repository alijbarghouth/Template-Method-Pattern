namespace Template_Method_Pattern.TemplatePatternWithHooks
{
    public class CoffeeWithHooks : CaffeineBeverageWithHooks
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing coffee");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
        protected override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();
            return answer.ToLower().StartsWith("y");
        }

        private static string GetUserInput()
        {
            string? answer = null;
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");

            return answer is null ? "n" : "y";
        }
    }
}