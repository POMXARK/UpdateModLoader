using AngleSharp;
using AngleSharp.Dom;
using AngleSharpExtantions;
using ModLoader.Model;
using ModLoader.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Xml.Linq;
using YamlDotNet.Core.Tokens;
using static System.Net.Mime.MediaTypeNames;

namespace ModLoader.Parsers
{
    public class SynthiraRu : ContentSynthiraRu, IParseConfig, IParseData
    {
        // propfull = быстро создать свойсво

        public SynthiraRu(string url) : base(url)
        {


        }

        //public string Name{ get => document.QuerySelectorAll(".filekmod .entryLink"); }

        public string DateUpdate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LinkToPageMod { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LinkDownload { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Img { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsUpdate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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

            using (var context = new Context())
            {

                context.SynthiraRu.AddRange(DataToList(data));
                context.SaveChanges();
            }
            
            return data.DumpAsYaml();
        }

        private List<Model.Entities.SynthiraRu> DataToList(IBlockData[] data)
        {
            List<Model.Entities.SynthiraRu> result = new List<Model.Entities.SynthiraRu>();

            foreach (var item in data)
            {
                var el = new Model.Entities.SynthiraRu();
                el.Name = item.Name;
                el.Description = item.Description;
                el.Link = item.Link;
                el.SourseDownload = item.SourseDownload;
                el.LinkDownload = item.LinkDownload;
                el.AboutMod = item.AboutMod;
                el.DateUpdate = item.DateUpdate[0];
                result.Add(el);
            }

            return result;

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

            return  datas.DumpAsYaml();
        }
    }
}
