
using ModLoader.DataAccess;
using ModLoader.Model;
using System.Collections.Generic;
using System.Linq;

namespace ModLoader.UI.Data.Repositories
{
    public class ModCollectionRepository : TableFields
    {
        public static void Create(string name, int parentId)
        {
            new EFGenericRepository<ModCollection>().CreateOrSkip(new ModCollection { Name = name, GamesId = parentId });
        }

        public static ModCollection Find(string name)
        {
            return new Context().Set<ModCollection>().Where(ModCollection => ModCollection.Name == name).FirstOrDefault();
        }

        public static IEnumerable<ModCollection> GetAll()
        {
            return new EFGenericRepository<ModCollection>().Get();
        }
    }
}
