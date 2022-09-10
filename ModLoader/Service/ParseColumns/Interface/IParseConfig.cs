namespace ModLoader.Service.ParseColumns.Interface
{
    internal interface IParseConfig
    {
        //string Name { get; }

        string DateUpdate { get; set; }
        string LinkToPageMod { get; set; }
        string LinkDownload { get; set; }
        string Img { get; set; }
        string Description { get; }
        bool IsUpdate { get; set; }
        //Task GetData();

    }
}
