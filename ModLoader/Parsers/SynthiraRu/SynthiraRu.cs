using AngleSharp.Dom;
using ModLoader.Extantions;
using ModLoader.Model;
using ModLoader.Model.Entities.Base;
using ModLoader.Service.Interface;
using System.Threading.Tasks;


namespace ModLoader.Parsers.SynthiraRu
{
    public class SynthiraRu : ContentSynthiraRu, IParseConfig, IParseData
    {
        // propfull = быстро создать свойсво

        public SynthiraRu(string url) : base(url)
        {


        }

        //public string Name{ get => document.QuerySelectorAll(".filekmod .entryLink"); }

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
            var test = GetType().Name;
            foreach (var item in data)
            {
                await ParsePage(item.Link, item);
            }

            var gameName = "Sims4";
            Games.Create(gameName);

            var collectionName = "OneCollection";
            ModCollection.Create(collectionName, Games.Find(gameName).Id);

            var packName = "OnePack";
            Pack.Create(packName, ModCollection.Find(collectionName).Id);


            saveData(data);

            //Model.Entities.SynthiraRu.Create(DataToList(data, resoureName));



            return data.DumpAsYaml();
        }

        private void saveData(IBlockData[] data)
        {

            foreach (var item in data)
            {
                var el = new WebResource();

                Mod.Create(item.Name, Pack.Find("OnePack").Id);

                el.ModId = Mod.Find(item.Name).Id;
                el.Url = "synthira.ru";
                el.Description = item.Description;
                el.Link = item.Link;
                el.SourseDownload = item.SourseDownload;
                el.LinkDownload = item.LinkDownload;
                el.AboutMod = item.AboutMod;
                el.DateUpdate = item.DateUpdate[0];
                //Extensions.RunDownload(el.LinkDownload, GetType().Name, item.Name, 30);
                //RunDownload(el.LinkDownload, item.Name, 20);
                //Process.Start("download", $"https://modsfire.com/d/{el.LinkDownload} C:\\Users\\User\\Downloads\\TEST\\downloads_new\\{item.Name} 20");
                WebResource.Create(el);

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
