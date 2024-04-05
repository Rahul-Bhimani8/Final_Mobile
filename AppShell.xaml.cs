using iStore.Pages;

namespace iStore
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SigninPage), typeof(SigninPage));
            Routing.RegisterRoute(nameof(SignupPage), typeof(SignupPage));
        }
        private readonly static Type[] _routablePageTypes =
        [
            typeof(SigninPage),
            typeof(SignupPage),
            typeof(CartorderPage),
            typeof(DetailsPage),
            typeof(HomePage),
            typeof(MyOrdersPage),
            typeof(NotificationPage),
            typeof(OnboardingPage),
            typeof(OrderDetailsPage),
            typeof(ProfilePage),
            typeof(SearchPage),
            typeof(ProductPage),
            typeof(Product),
        ];
        private static void RegisterRoutes()
        {
            foreach(var pageType in _routablePageTypes)
            {
                Routing.RegisterRoute(pageType.Name, pageType);
            }
        /*    Routing.RegisterRoute(nameof(SigninPage), typeof(SigninPage));
            Routing.RegisterRoute(nameof(SignupPage), typeof(SignupPage));*/
        }
        private async void FlyoutFooter_Tapped(object sender, TappedEventArgs e)
        {
            await Launcher.OpenAsync("https://www.google.com");
        }

        private async void SignoutMenuItem_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.DisplayAlert("Alert", "Signout menu item clicked", "Ok");
        }
    }
}
