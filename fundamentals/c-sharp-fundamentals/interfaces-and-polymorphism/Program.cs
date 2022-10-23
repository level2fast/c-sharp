using System.Xml.Xsl;

namespace interfaces_and_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificatioChannel());
            encoder.Encode(new Video());
        }
    }
}
