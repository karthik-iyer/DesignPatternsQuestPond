namespace StrategyPattern
{
    public class NoDiscountStrategy: IStrategy
    {
        public int GetFinalBill(int billAmount)
        {
            return billAmount;
        }
    }
}