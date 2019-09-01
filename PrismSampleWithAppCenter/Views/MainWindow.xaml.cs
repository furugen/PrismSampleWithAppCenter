using Microsoft.AppCenter.Analytics;
using Prism.Regions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PrismSampleWithAppCenter.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IRegionManager regionManager;

        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();

            this.regionManager = regionManager;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(this.regionManager.Regions["ContentRegion"].ActiveViews.Count() > 0)
            {
                Button btn = sender as Button;
                var activeView = this.regionManager.Regions["ContentRegion"].ActiveViews.First();

                Analytics.TrackEvent(activeView.ToString(), new Dictionary<string, string> {
                    { "ButtonName", btn.Name },
                    { "ButtonContent", btn.Content?.ToString() }
                });
            }

        }
    }
}
