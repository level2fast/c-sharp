namespace Amazon
{
    /// <summary>
    /// Example of using an internal class.
    /// RateCalculator can't be seen or used
    /// outside of this assembly because of internal
    /// declaration.
    /// </summary>
    internal class RateCalculator
    {
        public int Calculate(Customer customer)
        {
            return 0;
        }
    }
}