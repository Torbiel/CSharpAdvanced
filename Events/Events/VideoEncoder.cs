using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {
        // 1. Define a delegate.
        // We don't have to do it like this, because there is built-in event handler
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // 2. Define an event based on the delegate.
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            //Encoding logic...

            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            /*
             * This approach is bad, because every time we make a change to the services it affects this class and we have to add new
             * services here if such will be created.
             * 
             * _mailService.Send(new Mail());
             * _messageService.Send(new Text());
            */

            // 3. Raise the event.
            OnVideoEncoded(video);
        }

        // Event publisher methods should be protected virtual void and name should start with "On"
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
