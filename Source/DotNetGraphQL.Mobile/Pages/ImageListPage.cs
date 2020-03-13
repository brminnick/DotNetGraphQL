using System.Linq;
using DotNetGraphQL.Common;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DotNetGraphQL.Mobile
{
    class DogImageListPage : BaseContentPage<DogImageListViewModel>
    {
        public DogImageListPage()
        {
            ViewModel.PullToRefreshFailed += HandlePullToRefreshFailed;

            var collectionView = new CollectionView
            {
                ItemTemplate = new DogImageListDataTemplateSelector(),
                SelectionMode = SelectionMode.Single,
                EmptyView = new Label
                {
                    Text = "🐶",
                    FontSize = 128,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center,
                }
            };
            collectionView.SelectionChanged += HandleCollectionViewCollectionChanged;
            collectionView.SetBinding(CollectionView.ItemsSourceProperty, nameof(DogImageListViewModel.DogImageList));

            var refreshView = new RefreshView
            {
                Content = collectionView,
                RefreshColor = Color.FromHex("1F2B2E")
            };
            refreshView.SetBinding(RefreshView.IsRefreshingProperty, nameof(DogImageListViewModel.IsDogImageCollectionRefreshing));
            refreshView.SetBinding(RefreshView.CommandProperty, nameof(DogImageListViewModel.RefreshDogCollectionCommand));

            Title = "Favorite Dogs";

            Content = refreshView;
        }

        void HandlePullToRefreshFailed(object sender, string message) =>
            MainThread.BeginInvokeOnMainThread(async () => await DisplayAlert("Refresh Failed", message, "OK"));

        async void HandleCollectionViewCollectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var collectionView = (CollectionView)sender;
            collectionView.SelectedItem = null;

            if (e.CurrentSelection.FirstOrDefault() is DogImagesModel dogImagesModel)
            {
                //ToDo Navigate to Dog Images page
                await OpenBrowser(dogImagesModel.WebsiteUrl);
            }
        }
    }
}
