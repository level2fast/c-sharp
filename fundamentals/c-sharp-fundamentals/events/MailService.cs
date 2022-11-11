namespace events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Called MailService:onVideoEncoded EventHandler Title:" + args.Video.Title);
        }
    }
}
