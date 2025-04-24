namespace LightHTMLLibrary
{
    public class ImageNode : LightNode
    {
        public string Src { get; set; }
        public IImageLoaderStrategy LoaderStrategy { get; set; }

        public ImageNode(string src, IImageLoaderStrategy loader)
        {
            Src = src;
            LoaderStrategy = loader;
        }

        public override string InnerHTML => string.Empty;

        public override string OuterHTML => $"<img src=\"{Src}\" alt=\"{LoaderStrategy.Load(Src)}\" />";
    }
}
