using ModLoader.Model;
using System.Collections.Generic;

namespace ModLoader.UI.Data.Repositories
{
    public class WebResourceRepository
    {
        public static void Create(List<WebResource> list)
        {
            new EFGenericRepository<WebResource>().CreateOrSkip(list);
        }

        public static void Create(WebResource list)
        {
            new EFGenericRepository<WebResource>().CreateOrSkip(list);
        }

        public static IEnumerable<WebResource> GetAll()
        {
            return new EFGenericRepository<WebResource>().Get();
        }

    }
}
