namespace system
{
 // cannot inherit from "String" class
    //public class RichString: String
    //{
    //}

    // Need to use an extension method if you want
    // to extend it.


    /// <summary>
    /// This class defines an extension method that extends
    /// the functionality of the string class. This method
    /// will only be available.
    /// 
    /// Extension methods should only be used if you have too.
    /// They allow us to do the following:
    ///     -Add methods to an existing class without changing it's 
    ///      source code or create a new type that inherits from it.
    /// 
    /// </summary>
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("number of words should be >= 0");

            if (numberOfWords == 0)
                return "";
            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
   
}
