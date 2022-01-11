using ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    public class CreateCustomerHandler : Handler
    {
        public override object Handle(CreateCustomer customer)
        {
            if (customer == null)
                return null;

            Console.WriteLine("Customer created!");

            return base.Handle(customer);
        }
    }
}
