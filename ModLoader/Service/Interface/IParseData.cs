using AngleSharp.Dom;


<<<<<<<< HEAD:ModLoader/Service/AngleSharpParser/Interface/IParseData.cs
namespace ModLoader.Service.AngleSharpParser.Interface
========
namespace ModLoader.Service.Interface
>>>>>>>> 70a9e3c421f048c6c9d834cd8ec6bc260a8eac3c:ModLoader/Service/Interface/IParseData.cs
{
    internal interface IParseData
    {
        IHtmlCollection<IElement> Blocks { get; }
        IHtmlCollection<IElement> Names { get; }
        IHtmlCollection<IElement> Descriptions { get; }
    }
}
