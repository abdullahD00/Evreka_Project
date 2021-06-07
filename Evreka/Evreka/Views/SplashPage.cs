using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Evreka.Views
{
    class SplashPage : ContentPage
    {
        Image SplashImage;

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();

            SplashImage = new Image
            {
                Source = "evrekasplashscreen1.jpg",
                WidthRequest = 620,
                HeightRequest = 660
            };

            AbsoluteLayout.SetLayoutFlags(SplashImage,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SplashImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(SplashImage);

            this.BackgroundColor = Color.FromHex("#33a187");
            this.Content = sub;

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(5000);

            NavigationPage NavPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#003a67"),
                BarTextColor = Color.White
            };

            Application.Current.MainPage = NavPage;


        }
    }
}
