using System;
using System.Threading;
using System.Windows;
using System.Windows.Navigation;

namespace MassivePixel.ColorMe.WP8.Views
{
    public partial class BlinkerPage
    {
        private Timer _timer;
        private const double Interval = 250;

        public BlinkerPage()
        {
            InitializeComponent();
            DataContext = App.SelectedColor;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _timer = new Timer(OnTimer, null, TimeSpan.FromMilliseconds(Interval), TimeSpan.FromMilliseconds(Interval));
        }

        private void OnTimer(object state)
        {
            Dispatcher.BeginInvoke(() =>
            {
                ColoredRectangle.Visibility = ColoredRectangle.Visibility != Visibility.Visible
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            });
        }
    }
}