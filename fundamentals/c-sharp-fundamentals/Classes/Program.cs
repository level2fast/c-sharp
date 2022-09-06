// See https://aka.ms/new-console-template for more information
using System.Reflection.PortableExecutable;
using System.Collections.Generic;
using System.ComponentModel;

namespace classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id) 
            : this() // call paramerter-less constructor 1st
        {
            this.Id = id;
            Name = "";
        }
        public Customer(int id, string name)
            :this(id) // call constructer with integer param 1st
        {
            this.Id = id;
            this.Name = name;
        }
    }
    public class CustomerField
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders;
        public CustomerField()
        {
            Orders = new List<Order>();
        }
        public CustomerField(int id)
            : this() // call paramerter-less constructor 1st
        {
            this.Id = id;
            Name = "";
        }
        public CustomerField(int id, string name)
            : this(id) // call constructer with integer param 1st
        {
            this.Id = id;
            this.Name = name;
        }
        public void Promote()
        {
            // Error: Cannot initialize this field here
            // because it's readonly
            // Orders = new List<Order>();
        }
    }
    public class Order
    {
    }

    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
        public static int PeopleCount = 0;
    }

    public class Calculator
    {
        // Example: Using the params modifier to pass varying number of args
        public static int Add(params int[] nubmers) { int result = 0;  return result; }
    }

    public class MyClass
    {

        public static void MyMethod(ref int a)
        { a += 2; }
        public static void MyMethod2(out int result)
        { result = 2; }
    }

    // Example: Access Modifiers
    public class User
    {
        // expose Id to rest of program
        public int Id;
        // keep birthday hidden
        private DateTime _birthdate;

        // expose children to name
        protected string _name = "";

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

    }

    // Example: Properties, better way to implement get/set methods
    public class UserWithProperties
    {

        // expose Id to rest of program
        public int Id;
        // keep birthday hidden
        private DateTime _birthdate;

        // expose children to name
        protected string _name = "";

        #region properties
        // generated using shortcut "prop" + tab 
        public string testProp { get; set; }

        public DateTime Birthday { get; private set; }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthday;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
        #endregion


        public UserWithProperties(DateTime birthday)
        {
            Birthday = birthday;
        }
    }

    public class HttpCookie
    {
        private Dictionary<string, string> _dictionay;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionay = new Dictionary<string, string>();
        }

        /// <summary>
        /// Indexer property. Useful for getting/setting collections
        /// that should remain private
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string this[string key]
        {
            get { return _dictionay[key]; }
            set { _dictionay[key] = value; }
        }
            
    }
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            // Example: Basic class usage

            // Example: Creating an object
            var person = new Person();

            // Example: Using static member
            var p = Person.Parse("Joe");

            person.Name = "AJ";
            person.Introduce("Josh");


            // Example: Constructors
            Console.WriteLine("No params in constructor: Customer()");
            var customer = new Customer(); 
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Id);

            Console.WriteLine("1 param in constructor: Customer(int id)");
            var custome2 = new Customer(1);
            Console.WriteLine(custome2.Name);
            Console.WriteLine(custome2.Id);

            Console.WriteLine("2 param in constructor: Customer(int id, string name)");
            var customer3 = new Customer(1,"James");
            Console.WriteLine(customer3.Name);
            Console.WriteLine(customer3.Id);


            // Exmaple: Object Initializers
            var person2 = new Person
            {
                Name = "Joe"
            };

            // Example: Methods
            Console.WriteLine("Sum of { 1, 2, 3, 4, 5, 6 }: " + Calculator.Add(new int[] { 1, 2, 3, 4, 5, 6 }));
            Console.WriteLine("Sum of { 1, 2, 3 }: "          + Calculator.Add(1, 2, 3));
            Console.WriteLine("Sum of { 1, 2, 3, 4, 5, 6 }: " + Calculator.Add(1, 2, 3, 4, 5, 6));

            // using ref modifier
            var a = 1;
            MyClass.MyMethod(ref a);

            // using out modifieer
            MyClass.MyMethod2(out a);

            // Example: Fields
            var customerF = new CustomerField(1);
            customerF.Orders.Add(new Order());

            // Example: Access Modifiers
            // see User class

            // Example: Properties
            var usr = new UserWithProperties(new DateTime(1980, 1, 2));
            Console.WriteLine("Age: " + usr.Age);

            // Example: Indexers
            var cookie = new HttpCookie();
            cookie["name"] = "Steven";
            Console.WriteLine(cookie["name"]);
        }
    }

}
