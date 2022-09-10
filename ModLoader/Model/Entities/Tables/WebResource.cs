

using ModLoader.Model.Entities.Base;
using System;
using System.Collections.Generic;

namespace ModLoader.Model.Entities.Tables
{
    public class WebResource
    {
        public int Id { get; set; }
        public virtual Mod Mod { get; set; }
        public int ModId { get; set; }
        public string Url { get; set; }


        public string Description { get; set; }
        public DateTime DateUpdate { get; set; }
        public string Link { get; set; }
        public string SourseDownload { get; set; }
        public string LinkDownload { get; set; }
        public string AboutMod { get; set; }


        public static void Create(List<WebResource> list)
        {
            new EFGenericRepository<WebResource>().CreateOrSkip(list);
        }

        public static void Create(WebResource list)
        {
            new EFGenericRepository<WebResource>().CreateOrSkip(list);
        }

    }
}
