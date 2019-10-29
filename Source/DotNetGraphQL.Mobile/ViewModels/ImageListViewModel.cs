using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AsyncAwaitBestPractices.MVVM;
using DotNetGraphQL.Common;
using Xamarin.Forms;

namespace DotNetGraphQL.Mobile
{
    class ImageListViewModel : BaseViewModel
    {
        bool _isDogImageCollectionRefreshing;

        public ImageListViewModel()
        {
            RefreshDogCollectionCommand = new AsyncCommand(ExecuteRefreshDogCollectionCommand, _ => !IsDogImageCollectionRefreshing);
        }

        public ObservableCollection<DogImagesModel> DogImageCollection { get; } = new ObservableCollection<DogImagesModel>();
        public AsyncCommand RefreshDogCollectionCommand { get; }

        public bool IsDogImageCollectionRefreshing
        {
            get => _isDogImageCollectionRefreshing;
            set => SetProperty(ref _isDogImageCollectionRefreshing, value, () => Device.BeginInvokeOnMainThread(RefreshDogCollectionCommand.RaiseCanExecuteChanged));
        }

        async Task ExecuteRefreshDogCollectionCommand()
        {
            DogImageCollection.Clear();

            try
            {
                await foreach(var dogImageModel in GraphQLService.GetDogImages())
                {
                    DogImageCollection.Add(dogImageModel);
                }
            }
            finally
            {
                IsDogImageCollectionRefreshing = false;
            }
        }
    }
}
