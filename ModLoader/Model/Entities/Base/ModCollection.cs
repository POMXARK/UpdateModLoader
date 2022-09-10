
using GenRepApp;
using System.Linq;

namespace ModLoader.Model.Entities.Base
{
    public class ModCollection : TableFields
    {
        public virtual Games Games { get; set; }
        public int GamesId { get; set; }


        public static void Create(string name, int parentId)
        {
            new EFGenericRepository<ModCollection>().CreateOrSkip(new ModCollection { Name = name, GamesId = parentId });
        }

        public static ModCollection Find(string name)
        {
            return new Context().Set<ModCollection>().Where(ModCollection => ModCollection.Name == name).FirstOrDefault();
        }
    }
}
