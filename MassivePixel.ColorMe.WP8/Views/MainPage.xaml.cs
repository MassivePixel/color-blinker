// Copyright 2014 Massive Pixel j.d.o.o.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
//    limitations under the License. 

using System;
using System.Threading.Tasks;
using System.Windows.Controls;
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

        private void Colors_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var lb = sender as ListBox;
            if (lb == null)
                return;

            var cvm = lb.SelectedItem as ColorViewModel;
            if (cvm == null)
                return;

            App.SelectedColor = cvm;
            NavigationService.Navigate(new Uri("/Views/BlinkerPage.xaml", UriKind.Relative));
        }

        private void About_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/YourLastAboutDialog;component/AboutPage.xaml", UriKind.Relative));
        }
    }
}