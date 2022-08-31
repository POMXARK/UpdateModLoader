using AngleSharp.Dom;
using AngleSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html.Parser;

namespace ModLoader
{
    internal interface IBaseParse
    {
        Task ParseData();
        IConfiguration BrowserConfiguration { get; }
        IBlockData Data { get; }
        IBrowsingContext Context { get;}
        string Document { get;}
        string Url { get; set; }
        IHtmlCollection<IElement> FindAll(string cssSelectors);
        IElement Find(string cssSelectors);
        HtmlParser Parser { get; }
    }
}
