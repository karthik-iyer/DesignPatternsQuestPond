using System;
using InterfaceCustomer;
namespace ValidationAlgorithms{
    public class LeadValidation : IValidation<ICustomer>
    {
       public void Validate(ICustomer lead)
       {
            if(lead.CustomerName == string.Empty)
            {
                throw new Exception("CustomerName Cannot be empty");
            }
            if(lead.PhoneNumber == string.Empty)
            {
                throw new Exception("PhoneNumber Cannot be empty");
            }
       }
    }
}