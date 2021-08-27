using IntecApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntecApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /*MainPage = new NavigationPage(new LoginPage())
            {
                BarBackgroundColor = Color.White
            };*/
            MainPage = new MainPage();
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
