using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DistanceConverter.Views;

namespace DistanceConverter
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DistancePage());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
