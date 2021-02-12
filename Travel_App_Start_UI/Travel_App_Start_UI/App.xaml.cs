using System;
using Travel_App_Start_UI.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travel_App_Start_UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DestinationView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
