using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Event fundamentals:");
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService();   // subsriber
            var messageService = new MessageService();   // subsriber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);


        }
    }
}
