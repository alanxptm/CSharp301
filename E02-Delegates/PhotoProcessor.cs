namespace E02_Delegates;

public class PhotoProcessor
{
    public delegate void PhotoFilterHandler(Photo photo);
    
    // public void Process(string path, PhotoFilterHandler filterHandler)
    public void Process(string path, Action<Photo> filterHandler)
    {
        var photo = Photo.Load(path);

        // instead of...
        // var filters = new PhotoFilters();
        // filters.ApplyBrightness(photo);
        // filters.ApplyContrast(photo);
        // filters.Resize(photo);
        
        // use delegate
        filterHandler(photo);
        
        // system delegate
        // Action: void
        // Func: returns value

        photo.Save();
    }
}