using Xamarin.Forms;

namespace DotNetGraphQL.Mobile
{
    public class App : Application
    {
        public App()
        {
            FFImageLoading.ImageService.Instance.Initialize(new FFImageLoading.Config.Configuration
            {
                HttpHeadersTimeout = 60
            });

            MainPage = new BaseNavigationPage(new DogImageListPage());
        }
    }
}
