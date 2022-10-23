using System.Net.Mail;

namespace interfaces_and_polymorphism
{
    /// <summary>
    ///  
    /// </summary>
    public class VideoEncoder
    {
        public readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            // Notice polymorphic behavior here. The send method
            // is implemented by everyone who usese the INotification
            // interface. The VideoEncoder class does not know or care
            // about who's send method is being called. The exact send
            // method that get's called can vary. It could be an SMS
            // or Email notification or possibly some other class that
            // implements the INotification interface.. The send call
            // morphs into whichever object is being referenced in the
            // list of notification channels at the time of the Send() call.
            foreach (var channel in _notificationChannels)
                channel.Send(new Message());
        }
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
