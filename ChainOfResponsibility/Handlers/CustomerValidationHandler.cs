using ChainOfResponsibility.Models;
using ChainOfResponsibility.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    public class CustomerValidationHandler : Handler
    {
        public override object Handle(CreateCustomer customerCreate)
        {
            var validate = new CustomerValidation();

            var result = validate.Validate(customerCreate.Customer);

            if (result.IsValid)
            {
                return base.Handle(customerCreate);
            }

            return null;
        }
    }
}
