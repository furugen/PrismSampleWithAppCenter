using PrismSampleWithAppCenter.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace PrismSampleWithAppCenter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            AppCenter.Start("あなたのシークレットコード",
                   typeof(Analytics), typeof(Crashes));

            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
   
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<PageA.PageAModule>();
            moduleCatalog.AddModule<PageB.PageBModule>();
            moduleCatalog.AddModule<PageC.PageCModule>();
        }
    }
}
