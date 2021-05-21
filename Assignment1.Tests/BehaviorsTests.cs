using Assignment1.Implementation.Behaviors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Tests
{
    [TestClass]
    public class BehaviorsTests
    {
        [TestMethod]
        public void CommissionBehavior_Should_Return_ExpectedCommission()
        {
            //Arrange
            CommissionBehavior commissionBehavior = new CommissionBehavior();

            //Act
            var result = commissionBehavior.ProcessOrder();

            //Assert
            Assert.AreEqual(result, "Generate Commission");
        }
    }
}
