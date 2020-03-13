using Xamarin.Forms;

namespace DotNetGraphQL.Mobile
{
    public class App : Application
    {
        public App()
        {
            Device.SetFlags(new[] { "Markup_Experimental" });
            MainPage = new BaseNavigationPage(new DogImageListPage());
        }
    }
}
