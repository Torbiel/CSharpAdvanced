using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
