using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismSampleWithAppCenter.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand OnNavigateToPageACommand { get; set; }
        public DelegateCommand OnNavigateToPageBCommand { get; set; }
        public DelegateCommand OnNavigateToPageCCommand { get; set; }


        public MainWindowViewModel(IRegionManager regoinManager)
        {
            this.OnNavigateToPageACommand = new DelegateCommand(new System.Action(() =>
                {
                    regoinManager.RequestNavigate("ContentRegion", "PageAView");
                }
            ));
            this.OnNavigateToPageBCommand = new DelegateCommand(new System.Action(() =>
                {
                    regoinManager.RequestNavigate("ContentRegion", "PageBView");
                }
            ));
            this.OnNavigateToPageCCommand = new DelegateCommand(new System.Action(() =>
                {
                    regoinManager.RequestNavigate("ContentRegion", "PageCView");
                }
            ));

        }


    }
}
