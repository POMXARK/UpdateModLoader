
using AngleSharp.Dom;
using ModLoader.Model;
using ModLoader.Parser.AngleSharpParser;
using ModLoader.Parser.ParseColumns;
using ModLoader.Parser.Parsers.SynthiraRu;

using System.Threading.Tasks;

namespace ModLoader.UI.Data.Repositories
{
    public class SynthiraRuRepository // : ContentSynthiraRu, IParseConfig, IParseData
    {


        //    //public SynthiraRuRepository(string url) : base(url) {

        //    //}

        //    public string DateUpdate { get; set; }
        //    public string LinkToPageMod { get; set; }
        //    public string LinkDownload { get; set; }
        //    public string Img { get; set; }
        //    public string Description { get; set; }
        //    public bool IsUpdate { get; set; }

        //    public IHtmlCollection<IElement> Names => FindAll(".entryLink");

        //    public IHtmlCollection<IElement> Descriptions => FindAll(".messzhfg span");


        //    /// <summary>
        //    /// Основной метод
        //    /// </summary>
        //    /// <returns></returns>
        //    async public Task<string> GetData()
        //    {
        //        var data = GetContent();
        //        var test = GetType().Name;
        //        foreach (var item in data)
        //        {
        //            await ParsePage(item.Link, item);
        //        }

        //        var gameName = "Sims4";
        //        GamesRepository.Create(gameName);

        //        var collectionName = "OneCollection";
        //        ModCollectionRepository.Create(collectionName, GamesRepository.Find(gameName).Id);

        //        var packName = "OnePack";
        //        PackRepository.Create(packName, ModCollectionRepository.Find(collectionName).Id);


        //        saveData(data);

        //        return data.ToString();
        //    }

        //    private void saveData(IBlockData[] data)
        //    {

        //        foreach (var item in data)
        //        {
        //            var el = new WebResource();

        //            ModRepository.Create(item.Name, PackRepository.Find("OnePack").Id);

        //            el.ModId = ModRepository.Find(item.Name).Id;
        //            el.Url = "synthira.ru";
        //            el.Description = item.Description;
        //            el.Link = item.Link;
        //            el.SourseDownload = item.SourseDownload;
        //            el.LinkDownload = item.LinkDownload;
        //            el.AboutMod = item.AboutMod;
        //            el.DateUpdate = item.DateUpdate[0];
        //            WebResourceRepository.Create(el);

        //        }

        //    }

        //    public string GetData(string test)
        //    {
        //        var blocks = Blocks;
        //        IBlockData[] datas = new IBlockData[blocks.Length];
        //        for (int i = 0; i < blocks.Length; i++)
        //        {
        //            var data = Data;
        //            datas[i] = data;
        //        }

        //        return datas.ToString();
        //    }

        //}
    }
}
