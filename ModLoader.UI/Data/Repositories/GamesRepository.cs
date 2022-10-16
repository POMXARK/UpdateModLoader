using ModLoader.DataAccess;
using ModLoader.Model;
using System.Collections.Generic;
using System.Linq;

namespace ModLoader.UI.Data.Repositories
{
    public class GamesRepository : TableFields
    {
        public static void Create(string name)
        {
            new EFGenericRepository<Games>().CreateOrSkip(new Games { Name = name });
        }

        public static Games Find(string name)
        {
            return new Context().Set<Games>().Where(Games => Games.Name == name).FirstOrDefault();
        }

        public static IEnumerable<Games> GetAll()
        {
            return new EFGenericRepository<Games>().Get();
        }
    }

}
