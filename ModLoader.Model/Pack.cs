
namespace ModLoader.Model
{
    public class Pack : TableFields
    {
        public virtual ModCollection ModCollection { get; set; }
        public int ModCollectionId { get; set; }
        public DateTime DateUpdate { get; set; }
        public bool Active { get; set; }
    }
}
