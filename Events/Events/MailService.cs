using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending mail... " + e.Video.Title);
        }
    }
}
