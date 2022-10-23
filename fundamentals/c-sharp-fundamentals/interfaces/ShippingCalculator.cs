using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    /// <summary>
    /// Adding an interface helps to reduce the amount of 
    /// coupling in the program. An interface is just a 
    /// blueprint for how to implement a specific class.
    /// </summary>
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            
            return 0;
        }

    }
}
