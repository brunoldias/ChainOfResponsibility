using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Validations
{
    public class CustomerValidation : AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            // Avoid using if for validation
            RuleFor(c => c.Name).NotEmpty().WithMessage("Name cannot be null");
            RuleFor(c => c.Email).EmailAddress().NotEmpty().WithMessage("Email cannot be null");
            RuleFor(c => c.Document).NotEmpty().Must(DocumentIsValid).WithMessage("document is invalid");
        }

        private bool DocumentIsValid(string arg)
        {
            // document validating logic goes here

            return true;
        }
    }
}
