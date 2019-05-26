using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        /*
            A delegate to a group of methods which have the type void and take and argument of type Photo:
            public delegate void PhotoFilterHandler(Photo photo); 
            When using this delegate we have to pass it in the method in which we want to use it.

            There is no need for creating custom delegates, because we have built-in ones:
            System.Action<> <- points to functions that do not return any value (are of type void)
            System.Func<> <- points to functions that return value
        */
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            /*
                Not extensible nor flexible code:

                var filters = new PhotoFilters();
                filters.ApplyBrightness(photo);
                filters.ApplyContrast(photo);
                filters.Resize(photo);
            */

            photo.Save();
        }
    }
}
