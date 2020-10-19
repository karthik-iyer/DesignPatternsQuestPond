using System;
using InterfaceCustomer;
namespace MiddleLayer
{
    public class Customer : CustomerBase
    {  
        public Customer(IValidation<ICustomer> obj) : base(obj)
        {
            
        }
    }
}
