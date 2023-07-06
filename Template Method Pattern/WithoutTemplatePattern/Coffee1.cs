namespace Template_Method_Pattern.WithoutTemplatePattern
{
    public class Coffee1
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        private void BrewCoffeeGrinds()
        {
            Console.WriteLine("Brewing coffee");
        }
        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        private void AddSugarAndMilk()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

    }
}
