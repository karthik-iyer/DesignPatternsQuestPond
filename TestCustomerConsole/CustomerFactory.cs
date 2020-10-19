using System.Collections.Generic;
using InterfaceCustomer;
using Unity;
using MiddleLayer;
using ValidationAlgorithms;
namespace TestCustomerConsole{

    public static class CustomerFactory{
        private static IUnityContainer custs = null;
        public static ICustomer CreateCustomer(string custType)
        {
            if (custs == null)
            {
                custs = new UnityContainer();
                custs.RegisterType<ICustomer,Customer>("Customer");
                custs.RegisterType<ICustomer,Lead>("Lead");
            }
            return custs.Resolve<ICustomer>(custType);
        }
    }
}