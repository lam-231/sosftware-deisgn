namespace LightHTMLLibrary
{
    public interface IImageLoaderStrategy
    {
        string Load(string source);
    }

    public class FileImageLoader : IImageLoaderStrategy
    {
        public string Load(string source)
        {
            return $"(image loaded from file: {source})";
        }
    }

    public class NetworkImageLoader : IImageLoaderStrategy
    {
        public string Load(string source)
        {
            return $"(image loaded from web: {source})";
        }
    }
}
