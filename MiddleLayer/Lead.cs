using System;
using InterfaceCustomer;

namespace MiddleLayer
{
    public class Lead : CustomerBase
    {       
       public Lead(IValidation<ICustomer> obj) : base(obj)
       {
           
       }
    }
}