using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModLoader
{
    internal interface IParseData
    {
        IHtmlCollection<IElement> Blocks { get; }
        IHtmlCollection<IElement> Names { get; }
        IHtmlCollection<IElement> Descriptions { get; }
    }
}
