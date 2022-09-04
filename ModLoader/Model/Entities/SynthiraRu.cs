using GenRepApp;
using ModLoader.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModLoader.Model.Entities
{
    public class SynthiraRu: TableFields
    {
        public virtual WebResource WebResource { get; set; }
        public int WebResourceId { get; set; }

        public string Description { get; set; }
        public DateTime DateUpdate { get; set; }
        public string Link { get; set; }
        public string SourseDownload { get; set; }
        public string LinkDownload { get; set; }
        public string AboutMod { get; set; }


        public static void Create(List<SynthiraRu> list)
        {
            new EFGenericRepository<SynthiraRu>().CreateOrDefault(list);
        }

        public static SynthiraRu Find(string name)
        {
            return new Context().Set<SynthiraRu>().Where(SynthiraRu => SynthiraRu.Name == name).FirstOrDefault();
        }

    }
}
