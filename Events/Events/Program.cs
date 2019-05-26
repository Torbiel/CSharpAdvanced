using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Events is a mechanism for communication between objects, it helps building loosely coupled apps and helps extending them.
             * 
             */

            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // <- publisher
            var mailService = new MailService(); // <- subscriber
            var messageService = new MessageService(); // <- subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // <- handler
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
