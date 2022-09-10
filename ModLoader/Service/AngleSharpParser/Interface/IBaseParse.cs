using AngleSharp.Dom;
using AngleSharp;
using System.Threading.Tasks;
using AngleSharp.Html.Parser;
using ModLoader.Service.ParseColumns.Interface;

namespace ModLoader.Service.AngleSharpParser.Interface
{
    internal interface IBaseParse
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
