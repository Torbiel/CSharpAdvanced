using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YT web service
                // Read the data
                // Create a list of Video objects
            }
            catch(Exception ex)
            {
                throw new YouTubeException("Could not fetch the videos.", ex);
            }

            return new List<Video>();
        }
    }
}
