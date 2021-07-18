using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Login.View;


namespace XF_Login
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new XF_SignUpPage());
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
