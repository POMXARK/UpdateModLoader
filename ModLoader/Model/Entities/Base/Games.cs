
using GenRepApp;
using System.Linq;

namespace ModLoader.Model.Entities.Base
{
    public class Games : TableFields
    {
        public static void Create(string name)
        {
            new EFGenericRepository<Games>().CreateOrDefault(new Games { Name = name });
        }

        public static Games Find(string name)
        {
            return new Context().Set<Games>().Where(Games => Games.Name == name).FirstOrDefault();
        }
    }

}
