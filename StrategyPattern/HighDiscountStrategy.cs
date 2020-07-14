namespace StrategyPattern
{
    public class HighDiscountStrategy : IStrategy
    {
        public int GetFinalBill(int billAmount)
        {
            return (int)(billAmount - (0.5 * billAmount));
        }
    }
}