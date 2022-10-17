
using System.Windows;
using ModLoader.UI.Data.Repositories;
using ModLoader.UI.Data.Repositories.Interfaces;
using Prism.DryIoc;
using Prism.Ioc;

namespace ModLoader.UI
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return new MainWindow();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IGamesRepository, GamesRepository>();
            containerRegistry.Register<IModCollectionRepository, ModCollectionRepository>();
            containerRegistry.Register<IModRepository, ModRepository>();
            containerRegistry.Register<IPackRepository, PackRepository>();
            containerRegistry.Register<IWebResourceRepository, WebResourceRepository>();
        }
    }
}
