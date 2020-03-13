using Android.Content;
using DotNetGraphQL.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//workaround for https://github.com/xamarin/Xamarin.Forms/issues/8626 and https://github.com/xamarin/Xamarin.Forms/issues/8986

[assembly: ExportRenderer(typeof(Label), typeof(LabelCustomRenderer))]
namespace DotNetGraphQL.Droid
{
    class LabelCustomRenderer : Xamarin.Forms.Platform.Android.FastRenderers.LabelRenderer
    {
        public LabelCustomRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control is null || e.NewElement is null)
                return;

            Control.VerticalScrollBarEnabled = false;
        }
    }
}