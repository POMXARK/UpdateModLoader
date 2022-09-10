

using ModLoader.Model.Entities.Base;
using System.Linq;

namespace ModLoader.Model.Entities.Tables
{
    public class Games : TableFields
    {
        public static void Create(string name)
        {
            new EFGenericRepository<Games>().CreateOrSkip(new Games { Name = name });
        }

        public static Games Find(string name)
        {
            return new Context().Set<Games>().Where(Games => Games.Name == name).FirstOrDefault();
        }
    }

}
