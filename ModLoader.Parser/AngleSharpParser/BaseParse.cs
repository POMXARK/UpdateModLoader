

using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using ModLoader.Parser.ParseColumns;


namespace ModLoader.Parser.AngleSharpParser
{

    public class BaseParse : IBaseParse
    {
        protected string url;
        protected IDocument document;
        protected IBrowsingContext context;

        public BaseParse(string url)
        {
            this.url = url;
            context = BrowsingContext.New(BrowserConfiguration);
        }

        public IBrowsingContext Context { get => context; }
        public string Document { get => document.DocumentElement.OuterHtml; }


        public string Url { get => url; set => url = value; }

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

        public async Task SaveDataIntoLocalFolder(string url, string fileName)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    var fileInfo = new FileInfo(fileName);
                    using (var fileStream = fileInfo.OpenWrite())
                    {
                        await stream.CopyToAsync(fileStream);
                    }
                }
                else
                {
                    throw new Exception("File not found");
                }
            }
        }
    }
}
