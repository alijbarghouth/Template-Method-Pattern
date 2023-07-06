namespace Template_Method_Pattern.TemplatePatternWithHooks
{
    public abstract class CaffeineBeverageWithHooks
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments()) {
                AddCondiments();
            }
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        protected virtual void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}