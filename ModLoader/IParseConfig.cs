using AngleSharp;
using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModLoader
{
    internal interface IParseConfig
    {
        //string Name { get; }
        
        string DateUpdate { get; set; }
        string LinkToPageMod { get; set; }
        string LinkDownload { get; set; }
        string Img { get; set; }
        string Description { get;}
        bool IsUpdate { get; set; }
        //Task GetData();

    }
}
