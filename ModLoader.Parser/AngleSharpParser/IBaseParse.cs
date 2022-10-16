using AngleSharp.Dom;
using AngleSharp;
using System.Threading.Tasks;
using AngleSharp.Html.Parser;
using ModLoader.Parser.ParseColumns;

namespace ModLoader.Parser.AngleSharpParser

{
    public interface IBaseParse
    {
        Task ParseData();
        IConfiguration BrowserConfiguration { get; }
        IBlockData Data { get; }
        IBrowsingContext Context { get; }
        string Document { get; }
        string Url { get; set; }
        IHtmlCollection<IElement> FindAll(string cssSelectors);
        IElement Find(string cssSelectors);
        HtmlParser Parser { get; }
    }
}
