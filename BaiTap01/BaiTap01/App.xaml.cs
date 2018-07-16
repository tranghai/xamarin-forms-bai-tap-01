using BaiTap01.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BaiTap01
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        public App()
        {
            InitializeComponent();
#if DEBUG
            LiveReload.Init();
#endif
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginView());
            }
            else
            {
                MainPage = new NavigationPage(new MainView());
            }
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
