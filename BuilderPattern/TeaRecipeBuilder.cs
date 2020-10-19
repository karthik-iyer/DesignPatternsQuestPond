namespace BuilderPattern
{
    public abstract class TeaRecipeBuilder
    {

        private Tea _tea { get; set; }

        protected TeaRecipeBuilder()
        {
            _tea = new Tea();
        }

        public virtual void AddWater(bool addWater)
        {
            _tea.IsWaterAdded = addWater;
        }

        public virtual void BoilWater(bool boilWater)
        {
            _tea.IsWaterBoiled = boilWater;
        }

        public virtual void AddTeaBag(bool addTeaBag)
        {
            _tea.IsTeaBagAdded = addTeaBag;
        }

        public virtual void AddSugar(bool addSugar)
        {
            _tea.IsSugarAdded = addSugar;
        }

        public virtual void AddMilk(bool addMilk)
        {
            _tea.IsMilkAdded = addMilk;
        }

        public Tea Build()
        {
            return _tea;
        }
    }
}