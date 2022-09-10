using AngleSharp.Dom;

namespace ModLoader.Service.AngleSharpParser.Interface
{
    internal interface IParseData
    {
        IHtmlCollection<IElement> Blocks { get; }
        IHtmlCollection<IElement> Names { get; }
        IHtmlCollection<IElement> Descriptions { get; }
    }
}
