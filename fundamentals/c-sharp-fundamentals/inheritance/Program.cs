using System.Collections;

namespace inheritance
{
   
    #region Inheritance and Access Modifiers
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

    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class EngineControlUnit
    {
        private Logger _logger;

        public EngineControlUnit(Logger logger)
        {
            _logger = logger;
        }

        public void RecordEngineTemp()
        {
            _logger.Log("Recording engine temperature");
        }
    }

    #endregion

    #region Constructors and Inheritance
    /// <summary>
    /// Set of Classes demonstrating the use of constructor
    /// inheritance
    /// </summary>
    public class Vehicle
    {
        private readonly string _licensePlate;
        public Vehicle(string licensePlate)
        {
            _licensePlate = licensePlate;
            Console.WriteLine("License Plate: " + _licensePlate);

        }
    }
    public class Car : Vehicle
    {
        public Car(string licensePlate) : base(licensePlate)
        {
            // initialize fields specific to car class
        }
    }
    #endregion

    #region Upcasting and Downcasting

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public void draw()
        { 
        }
    }
    public class Circle : Shape
    {

    }

    public class Text : Shape 
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }
    #endregion

    #region Boxing and Unboxing
    /// <summary>
    /// Value types ae stored on the stack
    /// all primivites are stored on stack
    /// 
    /// Reference types are stored on heap
    /// any class is stored on the heap.
    /// 
    /// Boxing is the process of converting
    /// a value type instance to an object
    /// reference
    /// Example: 
    /// int number = 10;
    /// object obj = number;
    /// or
    /// object obj = 10;
    /// 
    /// With boxing CLR creates an object in
    /// the heap and then creates a object
    /// that references that value on the stack
    /// 
    /// unboxing does the opposite
    /// Example:
    /// object obj = 10;
    /// int number = (int)obj;
    /// </summary>


    #endregion

    #region Method Overriding
    public class Artist
    {
        public virtual void Draw()
        { 
            // Default Implementation
        }

    }
    public class Graphic : Artist
    {
        public override void Draw()
        {
            Console.WriteLine("Graphic artist drawing");
        }
    }
    public class Sketch : Artist
    {
        public override void Draw()
        {
            Console.WriteLine("Sketch artist drawing");
        }
    }

    public class Canvas
    {
        public void DrawShapes(List<Artist> artists)
        {
            foreach(var artist in artists)
            {
                artist.Draw();
            }
        }
    }
    #endregion


    #region Abstract Classes and Members
    public abstract class Laptop
    {
        public abstract void Assemble();
        public void setId()
        {
            Console.WriteLine("Set laptop Id");
        }
    }


    /// <summary>
    /// Inherits from abstract class
    /// All methods inherited from abstract
    /// class must be implemented. This forces
    /// the developer to follow the design
    /// </summary>
    public class Dell : Laptop
    {
        public override void Assemble()
        {
            Console.WriteLine("Assemble Dell laptop");
        }
    }
    #endregion

    #region Interfaces
    /// <summary>
    /// Used to build loosely coupled applications. When
    /// building software it's best to have loosely 
    /// coupled objects in the code
    /// </summary>
    

    

    #endregion
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            #region Inhertiance and Access Modifiers
            // Example: inheritance
            // The civic class has access to the Honda
            // class properties becahse a Civic "is a" Honda.
            var newCar = new Civic();
            newCar.Engine = "V-Tech";

            
            // Example Composition
            // Notice we pass a logging object to the
            // engine control unit. Create a "Has a" 
            // realationship. An ECU "has a" logger. Makes
            // the code more modular and reduces dependencies
            // between classes
            var ecu = new EngineControlUnit(new Logger());
            ecu.RecordEngineTemp();

            #endregion

            #region Constructors and Inheritance
            // Example Constructor Inheritance
            var v = new Car("AJK221");
            #endregion

            #region Upcasting and Downcasting
            // Example of Upcasting 
            // implicit conversion happens here
            Circle circle = new Circle();
            Shape shape = circle;

            // Example of downcasting
            // explicit cast required here
            Circle circle1 = (Circle)shape;

            // text and textShape reference the same
            // object in memory.
            Text text = new Text();
            Shape textShape = text;
            textShape.Width = 200;
            shape.Width = 100;

            // notice the width is 100
            Console.WriteLine(text.Width);

            // Example Upcasting: We can pass MemoryStream here because
            // on StreamReaders inheritance hiearchy
            StreamReader reader = new StreamReader(new MemoryStream());
            #endregion

            #region Boxing and Unboxing
            // Example: Boxing and unboxing

            // Boxing
            var list = new ArrayList();
            list.Add(10); // boxing happens because add take types object, valuetype
            list.Add("Mosh"); // no boxing, reference
            list.Add(DateTime.Now); // valuetype, so boxing happens

            
            // Unboxing
            
            // use a generic list instead to avoid objec creation
            var anotherList = new List<int>();
            // list of integers now stored so no boxing happens.
            // and we have type safety.
            anotherList.Add(1);

            #endregion

            #region Polymorphism
            // Example: Polymorphism
            // Pass a list of artist to canvas
            // class to observe the Sketch artist and
            // graphic artist both draw on the canvas. 
            // Use of virtual and override allow the
            // the draw method in the parent class
            // to behave differently depending on the
            // base class implementation.
            var artists = new List<Artist>();
            artists.Add(new Sketch());
            artists.Add(new Graphic());
            var canvas = new Canvas();
            canvas.DrawShapes(artists);

            #endregion

        }
    }

}
