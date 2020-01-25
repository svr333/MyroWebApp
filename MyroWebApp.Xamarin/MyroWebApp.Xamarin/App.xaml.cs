using Xamarin.Forms;
using MyroWebApp.Xamarin.Services;
using MyroWebApp.Xamarin.Views;
using MyroWebApp.Xamarin.Services.Implementations;

namespace MyroWebApp.Xamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<IMyroWebService, MyroWebService>();
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
