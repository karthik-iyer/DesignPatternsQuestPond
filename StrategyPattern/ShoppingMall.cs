namespace StrategyPattern
{
    public class ShoppingMall
    {
        public string CustomerName { get; set; }

        public int BillingAmount { get; set; }

        public IStrategy CurrentStrategy;

        public ShoppingMall(IStrategy newStrategy)
        {
            CurrentStrategy = newStrategy;
        }

        public int GetFinalBill()
        {
            return CurrentStrategy.GetFinalBill(BillingAmount);
        }
    }
}