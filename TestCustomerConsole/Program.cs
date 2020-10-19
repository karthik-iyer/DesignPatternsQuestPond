using System;
using InterfaceCustomer;

namespace TestCustomerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer customer = null;
            var cust = "Lead";
            customer = CustomerFactory.CreateCustomer(cust);
            customer.Validate();
            Console.WriteLine("Hello World!");
        }
    }
}
