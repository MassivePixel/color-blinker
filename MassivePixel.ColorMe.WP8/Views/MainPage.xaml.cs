using System;
using System.Threading.Tasks;
using System.Windows.Navigation;
using MassivePixel.ColorMe.WP8.ViewModels;
using Microsoft.Expression.Interactivity.Core;

namespace MassivePixel.ColorMe.WP8.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.NavigationMode == NavigationMode.New)
            {
                Task.Delay(TimeSpan.FromSeconds(2))
                    .ContinueWith(t =>
                    {
                        ExtendedVisualStateManager.GoToState(this, "Hiding", true);
                    }, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }
    }
}