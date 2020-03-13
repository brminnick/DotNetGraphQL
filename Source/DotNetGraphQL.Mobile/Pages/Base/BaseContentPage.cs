using System;
using System.Collections;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DotNetGraphQL.Mobile
{
    abstract class BaseContentPage<T> : ContentPage where T : BaseViewModel, new()
    {
        protected BaseContentPage()
        {
            BindingContext = ViewModel;
            BackgroundColor = Color.FromHex("65859C");
        }

        protected T ViewModel { get; } = new T();

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //If Collection View is Empty, Manually Trigger a Pull-to-Refresh
            if (Content is RefreshView refreshView
                && refreshView.Content is CollectionView collectionView
                && IsNullOrEmpty(collectionView.ItemsSource))
            {
                refreshView.IsRefreshing = true;
            }

            static bool IsNullOrEmpty(in IEnumerable? enumerable) => !enumerable?.GetEnumerator().MoveNext() ?? true;
        }

        protected Task OpenBrowser(Uri uri) => MainThread.InvokeOnMainThreadAsync(() => Browser.OpenAsync(uri));

        protected Task OpenBrowser(string url) => MainThread.InvokeOnMainThreadAsync(() => Browser.OpenAsync(url));
    }
}
