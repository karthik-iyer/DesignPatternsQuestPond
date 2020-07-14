using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingMall shoppingMall = new ShoppingMall(null);
            shoppingMall.CustomerName = $"{DateTime.Now.DayOfWeek.ToString()} customer";
            shoppingMall.BillingAmount = 1000;

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                    shoppingMall.CurrentStrategy = new LowDiscountStrategy();
                    break;
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    shoppingMall.CurrentStrategy = new HighDiscountStrategy();
                    break;

                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    shoppingMall.CurrentStrategy = new NoDiscountStrategy();
                    break;
                default:
                    shoppingMall.CurrentStrategy = new NoDiscountStrategy();
                    break;
            }

            Console.WriteLine($"Final Bill is : {shoppingMall.GetFinalBill()}");
        }
    }
}
