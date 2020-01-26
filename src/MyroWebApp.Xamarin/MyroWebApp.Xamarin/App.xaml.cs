using Xamarin.Forms;
using MyroWebApp.Xamarin.Services;
using MyroWebApp.Xamarin.Views;
using MyroWebApp.Xamarin.Services.Implementations;
using MyroWebApp.Xamarin.Entities;

namespace MyroWebApp.Xamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<IMyroWebService, MyroWebService>();
            DependencyService.Register<IDataStorage<Profile>, ProfileStorage>();
            DependencyService.Register<IGradesFormatService, DefaultGradesFormatService>();

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
