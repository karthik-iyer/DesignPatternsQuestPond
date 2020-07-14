namespace BuilderPattern
{
    public class TeaWithoutMilk : TeaRecipeBuilder
    {
        public Tea MakeTea()
        {
            base.AddWater(true);
            base.BoilWater(true);
            base.AddTeaBag(true);
            base.AddSugar(true);
            return Build();
        }
    }
}