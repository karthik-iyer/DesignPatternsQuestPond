namespace StrategyPattern
{
    public class LowDiscountStrategy : IStrategy
    {
        public int GetFinalBill(int billAmount)
        {
            return (int)(billAmount - (0.1 * billAmount));
        }
    }
}