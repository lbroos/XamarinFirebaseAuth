using FirebaseAuth.Services;
using FirebaseAuth.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirebaseAuth
{
    public partial class App : Application
    {
        IFirebaseAuthentication auth;

        public App()
        {
            InitializeComponent();

            auth = DependencyService.Get<IFirebaseAuthentication>();
            if (auth.IsSignIn())
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new LoginPage();
            }
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
