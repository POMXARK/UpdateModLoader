using AngleSharp.Dom;
using ModLoader.Model;
using ModLoader.Parser.AngleSharpParser;
using ModLoader.Parser.Extantions;
using ModLoader.Parser.ParseColumns;


namespace ModLoader.Parser.Parsers.SynthiraRu
{
    public class SynthiraRu : ContentSynthiraRu, IParseConfig, IParseData
    {

        public SynthiraRu(string url) : base(url) {}

        public string DateUpdate { get; set; }
        public string LinkToPageMod { get; set; }
        public string LinkDownload { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public bool IsUpdate { get; set; }

        public IHtmlCollection<IElement> Names => FindAll(".entryLink");

        public IHtmlCollection<IElement> Descriptions => FindAll(".messzhfg span");


        /// <summary>
        /// Основной метод
        /// </summary>
        /// <returns></returns>
        async public Task<string> GetData()
        {
            var data = GetContent();

            foreach (var item in data)
            {
                await ParsePage(item.Link, item);
            }

            saveData(data);

            return data.DumpAsYaml();
        }

        private void saveData(IBlockData[] data)
        {

            foreach (var item in data)
            {
                var el = new WebResource();
                el.Url = "synthira.ru";
                el.Description = item.Description;
                el.Link = item.Link;
                el.SourseDownload = item.SourseDownload;
                el.LinkDownload = item.LinkDownload;
                el.AboutMod = item.AboutMod;
                el.DateUpdate = item.DateUpdate[0];
            }

        }

        public string GetData(string test)
        {
            var blocks = Blocks;
            IBlockData[] datas = new IBlockData[blocks.Length];
            for (int i = 0; i < blocks.Length; i++)
            {
                var data = Data;
                var modInfo = blocks[i].Find(".entryLink");
                data.Link = modInfo.GetAttribute("href");
                data.Name = modInfo.Text().RemoveTabbing();
                data.Description = blocks[i].Find(".messzhfg span").Text();
                data.DateUpdate = blocks[i].Find(".datemsz").Html().ParseDate();
                datas[i] = data;
            }

            return datas.DumpAsYaml();
        }

    }
}
