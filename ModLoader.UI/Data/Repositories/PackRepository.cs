using ModLoader.DataAccess;
using ModLoader.Model;
using System.Collections.Generic;
using System.Linq;

namespace ModLoader.UI.Data.Repositories
{
    public class PackRepository : TableFields
    {
        public static void Create(string name, int parentId)
        {
            new EFGenericRepository<Pack>().CreateOrSkip(new Pack { Name = name, ModCollectionId = parentId });
        }

        public static Pack Find(string name)
        {
            return new Context().Set<Pack>().Where(Pack => Pack.Name == name).FirstOrDefault();
        }

        public static IEnumerable<Pack> GetAll()
        {
            return new EFGenericRepository<Pack>().Get();
        }
    }
}
