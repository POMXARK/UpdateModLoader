using ModLoaderPrism.Modules.ModuleName;
using ModLoaderPrism.Services;
using ModLoaderPrism.Services.Interfaces;
using ModLoaderPrism.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace ModLoaderPrism
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }
    }
}
