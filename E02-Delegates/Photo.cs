namespace E02_Delegates;

public class Photo
{
    public static Photo Load(string path) => new Photo();
    
    public void Save() => Console.WriteLine("Photo saved");
}