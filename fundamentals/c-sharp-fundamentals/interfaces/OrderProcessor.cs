namespace interfaces
{
    public class OrderProcessor
    {
        /// <summary>
        ///  This variable is needed to create loose coupling. Our
        ///  Shipping calculator object can now be passed into the 
        ///  constructor and used to initialize this variable. 
        ///  This way of doing things favors composition.
        /// </summary>
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
