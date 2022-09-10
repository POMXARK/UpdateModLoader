using AngleSharp.Dom;
using AngleSharp;
using System.Threading.Tasks;
using AngleSharp.Html.Parser;
using ModLoader.Service.ParseColumns.Interface;

<<<<<<<< HEAD:ModLoader/Service/AngleSharpParser/Interface/IBaseParse.cs
namespace ModLoader.Service.AngleSharpParser.Interface
========
namespace ModLoader.Service.Interface
>>>>>>>> 70a9e3c421f048c6c9d834cd8ec6bc260a8eac3c:ModLoader/Service/Interface/IBaseParse.cs
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
