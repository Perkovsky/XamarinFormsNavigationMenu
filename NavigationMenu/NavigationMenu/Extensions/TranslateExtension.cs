using System;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationMenu.Extensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        const string RESOURCE_ID = "NavigationMenu.Resource";

        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return "";

            ResourceManager temp = new ResourceManager(RESOURCE_ID, typeof(TranslateExtension).GetTypeInfo().Assembly);

            var translation = temp.GetString(Text);
            if (translation == null)
            {
				translation = Text; // HACK: Returns the key, which GETS DISPLAYED TO THE USER
            }
            return translation;
        }
    }
}
