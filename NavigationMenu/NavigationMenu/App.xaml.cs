using Xamarin.Forms;
using Xamarin.Forms.Xaml;
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

		}
	}
}
