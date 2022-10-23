namespace interfaces_and_polymorphism
{
    public class SmsNotificatioChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Send SMS message: " + message.ToString()); 
        }
    }
}
