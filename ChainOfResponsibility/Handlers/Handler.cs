using ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    public class Handler
    {
        public Handler _handler;
        public Handler nextHandler(Handler Handler)
        {
            _handler = Handler;

            return Handler;
        }

        public virtual object Handle(CreateCustomer customer)
        {
            if (_handler != null)
            {
                return _handler.Handle(customer);
            }
            else
            {
                return null;
            }
        }
    }
}

