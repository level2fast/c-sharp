// See https://aka.ms/new-console-template for more information

namespace inheritance
{
    public class Honda
    {
        public string Engine { get; set; }
        public string Transmission { get; set; }

        public Honda()
        {

        }

    }
    public class Civic : Honda
    {
        public Civic()
        {
        }
    }
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            // Example: inheritance
            // The civic class has access to the Honda
            // class properties.
            var newCar = new Civic();
            newCar.Engine = "V-Tech";
     
            // Example Composition
        }
    }

}
