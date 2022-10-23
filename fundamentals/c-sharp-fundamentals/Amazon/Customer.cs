namespace Amazon
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
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
            Console.WriteLine(rating);
        }

    }
}