
using GenRepApp;
using System.Linq;

namespace ModLoader.Model.Entities.Base
{
    public class WebResource : TableFields
    {
        public virtual Mod Mod { get; set; }
        public int ModId { get; set; }
        public string Url { get; set; }


        public static void Create(string name, string url, int parentId)
        {
            new EFGenericRepository<WebResource>().CreateOrDefault(new WebResource { Name = name, Url=url, ModId = parentId });
        }

        public static WebResource Find(string name)
        {
            return new Context().Set<WebResource>().Where(WebResource => WebResource.Name == name).FirstOrDefault();
        }
    }
}
