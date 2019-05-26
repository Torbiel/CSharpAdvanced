namespace Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            System.Console.WriteLine("Applying brightness...");
        }

        public void ApplyContrast(Photo photo)
        {
            System.Console.WriteLine("Applying contrast...");
        }

        public void Resize(Photo photo)
        {
            System.Console.WriteLine("Resizing...");
        }
    }
}
