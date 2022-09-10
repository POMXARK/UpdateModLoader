<<<<<<<< HEAD:ModLoader/Service/ParseColumns/Interface/IParseConfig.cs
﻿namespace ModLoader.Service.ParseColumns.Interface
========
﻿

namespace ModLoader.Service.Interface
>>>>>>>> 70a9e3c421f048c6c9d834cd8ec6bc260a8eac3c:ModLoader/Service/Interface/IParseConfig.cs
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
