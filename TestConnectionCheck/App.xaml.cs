using System;
using TestConnectionCheck.Service;
using TestConnectionCheck.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestConnectionCheck
{
    public partial class App : Application
    {
        public static IAert alertManage;
        public App()
        {
            InitializeComponent();
            ServiceLocator.Instance.Add<IAert, AlertViewModel>();
            alertManage = ServiceLocator.Instance.Resolve<IAert>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
