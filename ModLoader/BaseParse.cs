using AngleSharp.Dom;
using AngleSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net;
using AngleSharp.Html.Parser;

namespace ModLoader
{
    internal class BaseParse:  IBaseParse
    {
        protected string url;
        protected IDocument document;
        protected IBrowsingContext context;

        public BaseParse(string url)
        {
            this.url = url;
            context = BrowsingContext.New(BrowserConfiguration);
        }

        public IBrowsingContext Context { get => context;}
        public string Document { get => document.DocumentElement.OuterHtml; }


        public string Url{get => url; set => url = value;}

        public HtmlParser Parser => new(new HtmlParserOptions { IsNotConsumingCharacterReferences = true, });

        public IBlockData Data => new BlockData();

        public IConfiguration BrowserConfiguration => Configuration.Default.WithDefaultLoader();

        /// <summary>
        /// Поиск первого элемента в html документе
        /// </summary>
        /// <param name="cssSelectors"></param>
        /// <returns>IElement</returns>
        public IElement Find(string cssSelectors)
        {
            return document.QuerySelector(cssSelectors);
        }

        /// <summary>
        /// Поиск всех элементов в html документе
        /// </summary>
        /// <param name="cssSelectors"></param>
        /// <returns></returns>
        public IHtmlCollection<IElement> FindAll(string cssSelectors)
        {
            return document.QuerySelectorAll(cssSelectors);
        }

        async public Task ParseData()
        {
            document = await context.OpenAsync(url);
        }


    }
}
