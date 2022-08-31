using AngleSharp;
using AngleSharp.Dom;
using AngleSharpExtantions;
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
using static System.Net.Mime.MediaTypeNames;

namespace ModLoader
{
    internal class SynthiraRu : ContentSynthiraRu, IParseConfig, IParseData
    {
        // propfull = быстро создать свойсво

        internal SynthiraRu(string url) : base(url)
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


        async public Task<string> GetData()
        {   
            var data = GetContent();
            foreach (var item in data)
            {
                await ParsePage(item.Link, item);
            }
            return data.DumpAsYaml();
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
