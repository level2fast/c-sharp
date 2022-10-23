namespace interfaces_and_polymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Mail: " + message.ToString());
        }
    }
}
