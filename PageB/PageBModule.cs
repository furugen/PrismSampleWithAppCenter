using PageB.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PageB
{
    public class PageBModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<PageBView>();
        }
    }
}