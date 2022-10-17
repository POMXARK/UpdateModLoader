using ModLoader.DataAccess;
using ModLoader.Model;
using ModLoader.UI.Data.Repositories.Interfaces;
using System.Linq;

namespace ModLoader.UI.Data.Repositories
{
    public class GamesRepository : GenericRepository<Games, Context>,
                                    IGamesRepository
    {
        public GamesRepository(Context context) : base(context)
        {
        }

        public Games Find(string name)
        {
            return new Context().Set<Games>().Where(Games => Games.Name == name).FirstOrDefault();
        }
    }

}
