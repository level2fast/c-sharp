namespace events
{
    public class VideoEventArgs: EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // How to define an event:
        // 1- Define a delegate
        // 2- Define and event based on that delegate
        // 3- Raise the event
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        // public event VideoEncodedEventHandler VideoEncoded;

        // .NET provides a delegate type in 2 forms for us
        // EventHanlder
        // EventHanlder<TEventArgs>
        // now we can use: 
        public event EventHandler<VideoEventArgs> VideoEncoded;
        
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null) // check for subscribers
                VideoEncoded(this, new VideoEventArgs(){ Video = video}); // call event handler method(s)
        }
    }
}
