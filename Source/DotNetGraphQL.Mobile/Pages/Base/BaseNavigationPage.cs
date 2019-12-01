using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace DotNetGraphQL.Mobile
{
    public class BaseNavigationPage : Xamarin.Forms.NavigationPage
    {
        public BaseNavigationPage(Xamarin.Forms.Page root) : base(root)
        {
            On<iOS>().SetPrefersLargeTitles(true);

            BarBackgroundColor = Xamarin.Forms.Color.FromHex("765824");
            BarTextColor = Xamarin.Forms.Color.White;
        }
    }
}
