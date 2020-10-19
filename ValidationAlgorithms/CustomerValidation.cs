using System;
using InterfaceCustomer;

namespace ValidationAlgorithms
{
    public class CustomerValidation: IValidation<ICustomer>
    {
       public void Validate(ICustomer customer)
       {
            if(customer.CustomerName == string.Empty)
            {
                throw new Exception("CustomerName Cannot be empty");
            }
            if(customer.PhoneNumber == string.Empty)
            {
                throw new Exception("PhoneNumber Cannot be empty");
            }
            if(customer.BillAmount >= 0)
            {
                throw new Exception("BillAmount Cannot be empty");
            }
            if(customer.BillDate > DateTime.Today)
            {
                throw new Exception("Bill Date cannot be later than today");
            }
            if(customer.Address == string.Empty)
            {
                throw new Exception("Address Cannot be empty");
            }
       }
    }
}
