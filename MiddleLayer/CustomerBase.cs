using System;
using InterfaceCustomer;
namespace MiddleLayer
{
    public class CustomerBase : ICustomer
    {
        public string CustomerName { get; set; }
        public string  PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string  Address { get; set; }

        private readonly IValidation<ICustomer> validation;

        public CustomerBase(IValidation<ICustomer> validationObj)
        {
            validation = validationObj;
        }
        public virtual void Validate()
        {
            validation.Validate(this);
        }
    }
}