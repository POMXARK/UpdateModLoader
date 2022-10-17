using ModLoader.DataAccess;
using ModLoader.Model;
using ModLoader.UI.Data.Repositories.Interfaces;
using System.Linq;

namespace ModLoader.UI.Data.Repositories
{
    public class PackRepository : GenericRepository<Pack, Context>, IPackRepository
    {
        public PackRepository(Context context) : base(context)
        {
        }

        public Pack Find(string name)
        {
            return new Context().Set<Pack>().Where(Pack => Pack.Name == name).FirstOrDefault();
        }
    }
}
