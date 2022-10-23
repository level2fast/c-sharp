using interfaces;

namespace InterfaceTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Convention for naming unit test functions:
        /// METHODNAME_CONDITION_EXPECTATION
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_Order_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };
            orderProcessor.Process(order);
        }
        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetShipmentPropertyOfOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }
    public class FakeShippingCalculator: IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}