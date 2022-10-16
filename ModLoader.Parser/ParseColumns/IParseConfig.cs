namespace ModLoader.Parser.ParseColumns
{
    public interface IParseConfig
    {
        string DateUpdate { get; set; }
        string LinkToPageMod { get; set; }
        string LinkDownload { get; set; }
        string Img { get; set; }
        string Description { get; }
        bool IsUpdate { get; set; }
    }
}
