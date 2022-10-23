using Interfaces_and_extensibility;

namespace interfaces_and_extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path) 
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            // best to use a "using" statement here because there is an exception
            // handling mechanism that is implemented by the compiler. So if something
            // goes wrong the compiler will call the "dispose" method on the the 
            // streamwriter which takes care of managing the object for us.
            using (StreamWriter sw = new StreamWriter(_path, true))
            {
                sw.WriteLine(messageType + " " + message);
            }
        }
    }
}
