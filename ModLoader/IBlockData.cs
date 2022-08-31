using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModLoader
{
    internal interface IBlockData
    {
        string Name { get; set; }
        string Description { get; set; }
        List<DateTime> DateUpdate { get; set; }
        string Link { get; set; }
        string SourseDownload { get; set; }
        string LinkDownload { get; set; }
        string AboutMod { get; set; }
    }
}
