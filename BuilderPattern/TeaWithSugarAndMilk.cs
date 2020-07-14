namespace BuilderPattern
{
    public class TeaWithSugarAndMilk : TeaRecipeBuilder
    {
        public Tea MakeTea()
            {
                base.AddWater(true);
                base.BoilWater(true);
                base.AddTeaBag(true);
                base.AddSugar(true);
                base.AddMilk(true);
                return Build();
            }
    }
}