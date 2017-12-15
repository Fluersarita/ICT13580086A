using Xamarin.Forms;

namespace ICT13580086A
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var np = new NavigationPage(new NavPage1());

            var tp = new TabbedPage();
            tp.Children.Add(new tabPage1());
            tp.Children.Add(new tabPage2());
            tp.Children.Add(new tabPage3());

			var cp = new CarouselPage();
			cp.Children.Add(new tabPage1());
			cp.Children.Add(new tabPage2());
			cp.Children.Add(new tabPage3());

            var mp = new MasterDetailPage();
            mp.Master = new MenuPage();
            mp.Detail = new NavigationPage(new ICT13580086APage());

            MainPage = mp;
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
