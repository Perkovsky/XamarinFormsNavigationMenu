using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NavigationMenu.ViewModels;

namespace NavigationMenu.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
		public MasterPage()
		{
			InitializeComponent();
			BindingContext = new MasterViewModel();
		}
	}
}