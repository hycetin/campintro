using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    class CustomerManager : ICustomerManagerService
    {
        public void SignIn(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " "+ customer.LastName + " giriş yaptı.");
        }
    }
}
