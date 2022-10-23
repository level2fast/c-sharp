using Interfaces_and_extensibility;

namespace interfaces_and_extensibility
{
    public class ConsoleLogger: ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
        public void LogInfo(string message) 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}
