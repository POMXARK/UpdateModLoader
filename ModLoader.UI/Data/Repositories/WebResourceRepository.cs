using ModLoader.DataAccess;
using ModLoader.Model;
using ModLoader.UI.Data.Repositories.Interfaces;

namespace ModLoader.UI.Data.Repositories
{
    public class WebResourceRepository : GenericRepository<WebResource, Context>, 
        IWebResourceRepository
    {
        protected WebResourceRepository(Context context) : base(context)
        {
        }
    }
}
