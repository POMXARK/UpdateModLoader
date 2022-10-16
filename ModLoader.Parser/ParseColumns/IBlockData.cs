
namespace ModLoader.Parser.ParseColumns
{
    public interface IBlockData
    {
        string Name { get; set; }
        string Description { get; set; }
        List<DateTime> DateUpdate { get; set; }
        string Link { get; set; }
        string SourseDownload { get; set; }
        string LinkDownload { get; set; }
        string AboutMod { get; set; }
    }
}
