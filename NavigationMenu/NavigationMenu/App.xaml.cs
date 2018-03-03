using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using Plugin.Iconize;
using Plugin.Iconize.Fonts;
using NavigationMenu.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NavigationMenu
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Iconize.With(new FontAwesomeModule());

            MainPage = new MasterDetailPage()
            {
                Master = new MasterPage(),
                Detail = new NavigationPage(new MainPage())
            };

            InitializeDependencies(MainPage as MasterDetailPage);
        }

        protected void InitializeDependencies(MasterDetailPage mdp)
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(mdp);
            var locator = new AutofacServiceLocator(builder.Build());
            ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}
