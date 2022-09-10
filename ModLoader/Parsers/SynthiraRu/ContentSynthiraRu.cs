using AngleSharp.Dom;
using ModLoader.Extantions;
using ModLoader.Model;
using ModLoader.Service.Parser;
using System;
using System.Threading.Tasks;

namespace ModLoader.Parsers.SynthiraRu
{
    public class ContentSynthiraRu : BaseParse
    {
        public ContentSynthiraRu(string url) : base(url)
        { }
        public IHtmlCollection<IElement> Blocks => FindAll(".filekmod");

        public IBlockData[] GetContent()
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
            return datas;
        }

        public async Task<IBlockData> ParsePage(string link, IBlockData data)
        {
            // https://over.wiki/ask/how-to-parse-correctly-using-anglesharp/
            // https://learn.javascript.ru/css-selectors
            SynthiraRu soup = new SynthiraRu(link);
            await soup.ParseData();
            var links = soup.FindAll(".button28");
            data.SourseDownload = links[0].GetAttribute("href");
            try
            {
                data.LinkDownload = links[1].GetAttribute("href").ModsfireDownloadLink();
            }
            catch (Exception)
            {

                data.LinkDownload = "ERROR";
            }

            data.AboutMod = soup.Find("#tab1").Html();
            return data;
        }
    }
}
