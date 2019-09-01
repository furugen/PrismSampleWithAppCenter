using PageA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PageA
{
    public class PageAModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<PageAView>();
        }
    }
}