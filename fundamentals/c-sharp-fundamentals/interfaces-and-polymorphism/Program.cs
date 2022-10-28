using System.Xml.Xsl;

namespace interfaces_and_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Notice the open/closed principle is demonstrated here. The 
            // VideoEncoder class is open to be extended but closed for 
            // modification. This means that we can change VideoEncoder behavior
            // by using depency injection without needed to change the 
            // underlying code in VideoEncoder. 
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificatioChannel());
            encoder.Encode(new Video());
        }
    }
}
