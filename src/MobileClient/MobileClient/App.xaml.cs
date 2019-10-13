using MobileClient.Shared.Services;
using Xamarin.Forms;

namespace MobileClient
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitDependencies();
            MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.Gray, BarTextColor = Color.White };
        }

        private void InitDependencies()
        {
            DependencyService.Register<IApiFactory<ITodoService>, ApiFactory<ITodoService>>();
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
