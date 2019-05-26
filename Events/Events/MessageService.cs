using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending message... " + e.Video.Title);
        }
    }
}
