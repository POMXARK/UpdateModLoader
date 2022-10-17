using ModLoader.DataAccess;
using ModLoader.Model;
using ModLoader.UI.Data.Repositories.Interfaces;
using System.Linq;

namespace ModLoader.UI.Data.Repositories
{
    public class ModRepository: GenericRepository<Mod, Context>, 
        IModRepository
    {
        protected ModRepository(Context context) : base(context)
        {
        }

        public Mod Find(string name)
        {
            return new Context().Set<Mod>().Where(Mod => Mod.Name == name).FirstOrDefault();
        }
    }
}
