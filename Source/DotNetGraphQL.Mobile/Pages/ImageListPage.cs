using System.Collections.Generic;
using System.Linq;
using DotNetGraphQL.Common;
using Xamarin.Forms;

namespace DotNetGraphQL.Mobile
{
    class ImageListPage : BaseContentPage<ImageListViewModel>
    {
        readonly RefreshView _refreshView;

        public ImageListPage()
        {
            var collectionView = new CollectionView
            {
                ItemTemplate = new DogImageListDataTemplate(),
                SelectionMode = SelectionMode.Single,
            };
            collectionView.SelectionChanged += HandleCollectionViewCollectionChanged;
            collectionView.SetBinding(CollectionView.ItemsSourceProperty, nameof(ImageListViewModel.DogImageCollection));

            _refreshView = new RefreshView { Content = collectionView };
            _refreshView.SetBinding(RefreshView.IsRefreshingProperty, nameof(ImageListViewModel.IsDogImageCollectionRefreshing));
            _refreshView.SetBinding(RefreshView.CommandProperty, nameof(ImageListViewModel.RefreshDogCollectionCommand));

            Content = _refreshView;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if(_refreshView.Content is CollectionView collectionView
                && collectionView.ItemsSource is ICollection<DogImagesModel> dogImagesCollection
                && !dogImagesCollection.Any())
            {
                _refreshView.IsRefreshing = true;
            }
        }

        async void HandleCollectionViewCollectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var collectionView = (CollectionView)sender;
            collectionView.SelectedItem = null;

            if (e.CurrentSelection.FirstOrDefault() is DogImagesModel dogImagesModel)
            {
                //ToDo Navigate to Dog Images page
                await OpenBrowser(dogImagesModel.AvatarUrl);
            }
        }
    }
}
