namespace Generics
{
    // where T: Product - constraint to an object
    public class Product
    {
        public string? Title { get; set; }
        public float Price { get; set; }
    }

    /// <summary>
    /// This constraint defines a function that accepts a 
    /// Product object or any of it's subclasses
    /// </summary>
    /// <typeparam name="TProduct"></typeparam>
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}