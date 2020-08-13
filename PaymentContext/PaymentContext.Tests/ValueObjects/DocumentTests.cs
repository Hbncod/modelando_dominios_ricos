using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.ValueObjects
{
    class DocumentTests
    {
        //Red , Green, Refactor
        //Red: fazer eles falharem
        //Green: fazer eles darem certo
        //Refactor: Refatora-los

        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            Assert.Fail();
        }
        [TestMethod]
        public void ShouldReturnSucessWhenCNPJIsInvalid()
        {
            Assert.Fail();
        }
        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            Assert.Fail();
        }
        [TestMethod]
        public void ShouldReturnSucessWhenCPFIsInvalid()
        {
            Assert.Fail();
        }
    }
}
