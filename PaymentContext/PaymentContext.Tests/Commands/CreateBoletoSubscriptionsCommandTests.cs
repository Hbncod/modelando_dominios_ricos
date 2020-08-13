using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Commands
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTest
    {
        [TestMethod]
        public void ShouldReturnErrorWhenNameIsInval()
        {
            CreateBoletoSubscriptionsCommand v = new CreateBoletoSubscriptionsCommand();
        }
    }
}
