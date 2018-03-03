using System;
using System.Windows.Input;
using Xamarin.Forms;
using CommonServiceLocator;

namespace NavigationMenu.ViewModels
{
    public class MasterViewModel
    {
        public ICommand NavigationCommand
        {
            get
            {
                return new Command((value) =>
                {
                    //NOTE: This is just quick demo code. Please don't put this in a production app
                    //var mdp = (Application.Current.MainPage as MasterDetailPage);

                    var mdp = ServiceLocator.Current.GetInstance<MasterDetailPage>();
                    var navPage = mdp.Detail as NavigationPage;

                    // hide the Master Detail Page
                    mdp.IsPresented = false;

                    navPage.PushAsync((Page)Activator.CreateInstance(value as Type));
                });
            }
        }
    }
}
