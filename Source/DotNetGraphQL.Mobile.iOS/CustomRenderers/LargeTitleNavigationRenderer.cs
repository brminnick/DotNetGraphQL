using CoreGraphics;
using DotNetGraphQL.Mobile.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(LargeTitleNavigationRenderer))]
namespace DotNetGraphQL.Mobile.iOS
{
    public class LargeTitleNavigationRenderer : NavigationRenderer
    {

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            UpdateNavigationBarColors();
        }

        void UpdateNavigationBarColors()
        {
            NavigationBar.Layer.ShadowColor = UIColor.Black.CGColor;
            NavigationBar.Layer.ShadowOffset = new CGSize(0, 0);
            NavigationBar.Layer.ShadowOpacity = 1;

            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0)
                    && Element is NavigationPage navigationPage)
            {
                var navigationPageBackgroundColor = navigationPage.BarBackgroundColor;

                NavigationBar.StandardAppearance.BackgroundColor = navigationPageBackgroundColor == Color.Default
                                                                    ? UINavigationBar.Appearance.BarTintColor
                                                                    : navigationPageBackgroundColor.ToUIColor();

                NavigationBar.StandardAppearance.TitleTextAttributes = NavigationBar.TitleTextAttributes;
                NavigationBar.StandardAppearance.LargeTitleTextAttributes = NavigationBar.LargeTitleTextAttributes;

                NavigationBar.ScrollEdgeAppearance = NavigationBar.StandardAppearance;
            }
        }
    }
}
