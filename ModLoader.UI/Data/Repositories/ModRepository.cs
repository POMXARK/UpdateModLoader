using ModLoader.DataAccess;
using ModLoader.Model;
using System.Collections.Generic;
using System.Linq;

namespace ModLoader.UI.Data.Repositories
{
    public class ModRepository : TableFields
    {
        public static void Create(string name, int parentId)
        {
            new EFGenericRepository<Mod>().CreateOrSkip(new Mod { Name = name, PackId = parentId });
        }

        public static Mod Find(string name)
        {
            return new Context().Set<Mod>().Where(Mod => Mod.Name == name).FirstOrDefault();
        }

        public static IEnumerable<Mod> GetAll()
        {
            return new EFGenericRepository<Mod>().Get();
        }
    }
}
