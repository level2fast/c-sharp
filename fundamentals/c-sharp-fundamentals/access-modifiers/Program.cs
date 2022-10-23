// See https://aka.ms/new-console-template for more information

namespace access_modifiers
{

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Public method use here since we want
        /// to be able to promote the customer
        /// when a certain criteria is met.
        /// </summary>
        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
                Console.WriteLine("Promote to level 1");
            else
                Console.WriteLine("Promote to level 2");
        }

        /// <summary>
        ///  Private method used here since we don't
        ///  want how we calculate the customer rating
        ///  to be exposed. This method cannot be accssed
        ///  outside of this class
        /// </summary>
        /// <returns></returns>
        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }

        /// <summary>
        ///  Protected method used here so that
        ///  dervied classes can update the customer 
        ///  rating. This method caon only be accessed
        ///  by children of this class.
        /// </summary>
        protected void UpdateRating()
        {
        }


        public class EntryPoint
        {
            static void Main(string[] args)
            {
                var customer = new Customer();
                customer.Name = "Joe";
                customer.Id = 1;

            }
        }

    }

    /// <summary>
    /// Child-class demonstrating the use of 
    /// protected methods
    /// </summary>
    public class GoldCustomer : Customer
    {

        public void OfferVoucher()
        {
             // call to protected method which
             // we can see only because we are a 
             // child class of Customer
             this.UpdateRating();
        }
    }
}
