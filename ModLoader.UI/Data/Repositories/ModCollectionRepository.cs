
using ModLoader.DataAccess;
using ModLoader.Model;
using ModLoader.UI.Data.Repositories.Interfaces;
using System.Linq;

namespace ModLoader.UI.Data.Repositories
{
    public class ModCollectionRepository : GenericRepository<ModCollection, Context>,
        IModCollectionRepository
    {
        protected ModCollectionRepository(Context context) : base(context)
        {
        }

        public static ModCollection Find(string name)
        {
            return new Context().Set<ModCollection>().Where(ModCollection => ModCollection.Name == name).FirstOrDefault();
        }
    }
}
