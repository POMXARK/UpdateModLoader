

using GenRepApp;
using System.Linq;

namespace ModLoader.Model.Entities.Base
{
    public class Mod : TableFields
    {
        public virtual Pack Pack { get; set; }
        public int PackId { get; set; }


        public static void Create(string name, int parentId)
        {
            new EFGenericRepository<Mod>().CreateOrDefault(new Mod { Name = name, PackId = parentId });
        }

        public static Mod Find(string name)
        {
            return new Context().Set<Mod>().Where(Mod => Mod.Name == name).FirstOrDefault();
        }
    }
}
