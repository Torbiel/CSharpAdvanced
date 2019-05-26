using System;
using System.IO;

namespace Exceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                using (var streamReader = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch
            {
                Console.WriteLine("An unexpected error occured.");
            }
            finally
            {
                /*
                 * We need to close the stream using Dispose() method in case of an exception or else we'll end up with file opened.
                 * The same applies to DB connections, network connections, graphic handlers, etc.
                 
                if(streamReader != null)
                {
                    streamReader.Dispose();
                }

                But we did it automatically using the "using" statement, so there's no need for finally block.
                */
            }
        }
    }
}
