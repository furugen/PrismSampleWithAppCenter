using PageC.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PageC
{
    public class PageCModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<PageCView>();
        }
    }
}