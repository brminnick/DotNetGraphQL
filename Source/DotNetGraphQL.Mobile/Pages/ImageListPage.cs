using System.Linq;
using DotNetGraphQL.Common;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Markup;

namespace DotNetGraphQL.Mobile
{
    class DogImageListPage : BaseContentPage<DogImageListViewModel>
    {
        public DogImageListPage()
        {
            ViewModel.PullToRefreshFailed += HandlePullToRefreshFailed;

            Title = "Favorite Dogs";

            Content = new RefreshView
            {
                RefreshColor = Color.FromHex("1F2B2E"),

                Content = new CollectionView
                {
                    EmptyView = new Label { Text = "🐶" }.Font(size: 128).Center().TextCenter(),
                    ItemTemplate = new DogImageListDataTemplateSelector(),
                    SelectionMode = SelectionMode.Single,
                }.Bind(CollectionView.ItemsSourceProperty, nameof(DogImageListViewModel.DogImageList))
                 .Invoke(collectionView => collectionView.SelectionChanged += HandleCollectionViewSelectionChanged)

            }.Bind(RefreshView.CommandProperty, nameof(DogImageListViewModel.RefreshDogCollectionCommand))
             .Bind(RefreshView.IsRefreshingProperty, nameof(DogImageListViewModel.IsDogImageCollectionRefreshing));
        }

        void HandlePullToRefreshFailed(object sender, string message) =>
            MainThread.BeginInvokeOnMainThread(async () => await DisplayAlert("Refresh Failed", message, "OK"));

        async void HandleCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var collectionView = (CollectionView)sender;
            collectionView.SelectedItem = null;

            if (e.CurrentSelection.FirstOrDefault() is DogImagesModel dogImagesModel)
            {
                await OpenBrowser(dogImagesModel.WebsiteUrl);
            }
        }
    }
}
