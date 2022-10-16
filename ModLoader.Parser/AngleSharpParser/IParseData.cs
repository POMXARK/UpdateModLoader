using AngleSharp.Dom;

namespace ModLoader.Parser.AngleSharpParser
{
    public interface IParseData
    {
        IHtmlCollection<IElement> Blocks { get; }
        IHtmlCollection<IElement> Names { get; }
        IHtmlCollection<IElement> Descriptions { get; }
    }
}
