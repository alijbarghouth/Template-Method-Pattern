namespace Template_Method_Pattern.WithoutTemplatePattern
{
    public class Tea1
    {
        public void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void SteepTeaBag()
        {
            Console.WriteLine("Steeping tea bag");
        }
        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        private void AddLemon()
        {
            Console.WriteLine("Adding lemon");
        }


    }
}
