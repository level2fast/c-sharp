namespace events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Called MessageService:onVideoEncoded EventHandler, Title:" + args.Video.Title);
        }

    }
}
