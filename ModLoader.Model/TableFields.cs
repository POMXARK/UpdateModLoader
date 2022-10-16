
using Microsoft.EntityFrameworkCore;

namespace ModLoader.Model
{
    [Index(nameof(Name), IsUnique = true)]
    public abstract class TableFields
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
