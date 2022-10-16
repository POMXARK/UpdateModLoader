

namespace ModLoader.Model
{
    public class Mod : TableFields
    {
        public virtual Pack Pack { get; set; }
        public int PackId { get; set; }
    }
}
