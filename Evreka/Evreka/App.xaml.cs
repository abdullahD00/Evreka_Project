using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Evreka.Views;


namespace Evreka
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SplashPage();
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
