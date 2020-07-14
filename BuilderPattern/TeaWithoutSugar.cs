namespace BuilderPattern
{
    public class TeaWithoutSugar : TeaRecipeBuilder
    {
        public TeaWithoutSugar() : base()
        {
        }

        public Tea MakeTea()
        {
            base.AddWater(true);
            base.BoilWater(true);
            base.AddTeaBag(true);
            return Build();
        }
    }
}