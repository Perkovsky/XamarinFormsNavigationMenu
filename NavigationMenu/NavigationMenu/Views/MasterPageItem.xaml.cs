using System;
using Xamarin.Forms;

namespace NavigationMenu.Views
{
    public partial class MasterPageItem : Grid
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }

        public MasterPageItem()
        {
            InitializeComponent();
        }
    }
}