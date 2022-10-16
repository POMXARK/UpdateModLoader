
namespace ModLoader.Model
{
    public class ModCollection : TableFields
    {
        public virtual Games Games { get; set; }
        public int GamesId { get; set; }
    }
}
