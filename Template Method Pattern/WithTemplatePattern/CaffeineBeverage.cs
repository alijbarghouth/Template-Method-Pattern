namespace Template_Method_Pattern.WithTemplatePattern
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        protected virtual void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected virtual void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}