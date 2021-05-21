using Assignment1.Implementation;
using Assignment1.Implementation.Behaviors;
using Assignment1.Implementation.Orders;
using Assignment1.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1.Tests
{
    [TestClass]
    public class OrdersTest
    {
        [TestMethod]
        public void BookOrder_Should_Return_Expected_Order_Behavior()
        {
            //Arrange
            var expectedOrderBehaviors = new List<IOrderBehavior>();
            expectedOrderBehaviors.Add(new DuplicatePackingSlipBehavior());
            expectedOrderBehaviors.Add(new CommissionBehavior());

            var expectedOrderBehaviorsSteps = expectedOrderBehaviors.Select(i => i.ProcessOrder()).ToList();

            //Act
            BookOrder bookOrder = new BookOrder();
            var behaviors = bookOrder.OrderBehaviors;

            var behaviorsSteps = behaviors.Select(i => i.ProcessOrder()).ToList();

            //Assert
            Assert.AreEqual(behaviors.Count, expectedOrderBehaviors.Count);
            CollectionAssert.AreEqual(expectedOrderBehaviorsSteps, behaviorsSteps);
        }

        [TestMethod]
        public void MemberShipOrder_Should_Return_Expected_Order_Behavior()
        {
            //Arrange

            Order order = new MembershipOrder();
            var expectedOrderBehaviors = new List<IOrderBehavior>();
            expectedOrderBehaviors.Add(new MembershipBehavior());
            expectedOrderBehaviors.Add(new EmailBehavior());

            var expectedOrderSteps = expectedOrderBehaviors.Select(i => i.ProcessOrder()).ToList();


            //Act
            var behaviors = order.ProcessOrder();

            //Assert
            Assert.AreEqual(behaviors.Count, expectedOrderBehaviors.Count);
            CollectionAssert.AreEqual(expectedOrderSteps, behaviors);
        }
    }
}
