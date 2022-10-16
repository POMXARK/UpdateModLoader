
namespace ModLoader.Model
{
    public class WebResource
    {
        public int Id { get; set; }
        public virtual Mod Mod { get; set; }
        public int ModId { get; set; }
        public string Url { get; set; }


        public string Description { get; set; }
        public DateTime DateUpdate { get; set; }
        public string Link { get; set; }
        public string SourseDownload { get; set; }
        public string LinkDownload { get; set; }
        public string AboutMod { get; set; }
    }
}
