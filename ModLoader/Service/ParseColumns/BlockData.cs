using System;
using System.Collections.Generic;
using ModLoader.Service.ParseColumns.Interface;

namespace ModLoader.Service.ParseColumns
{
    public struct BlockData : IBlockData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<DateTime> DateUpdate { get; set; }
        public string Link { get; set; }
        public string SourseDownload { get; set; }
        public string LinkDownload { get; set; }
        public string AboutMod { get; set; }

    }
}
