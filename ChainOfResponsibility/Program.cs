using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Models;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var createCustomer = new CreateCustomer()
            {
                Customer = new Customer()
                {
                    Document = "123546789",
                    Name = "Wilson Watt",
                    Email = "valid@email.com"
                }
            };

            // When to use handler each one have a responsibilities, case that be broken return null result or customer mensagem
            var createCustomerHandler = new CreateCustomerHandler();
            var customerValidationHandler = new CustomerValidationHandler();

            // Create sequences to pass responsibilities
            createCustomerHandler
                .nextHandler(customerValidationHandler);

            // Going through the responsibilities
            createCustomerHandler.Handle(createCustomer);

            Console.ReadKey();
        }
    }
}
