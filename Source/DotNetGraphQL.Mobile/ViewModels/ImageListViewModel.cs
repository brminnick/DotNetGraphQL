using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncAwaitBestPractices;
using AsyncAwaitBestPractices.MVVM;
using DotNetGraphQL.Common;
using Xamarin.Essentials;

namespace DotNetGraphQL.Mobile
{
    class DogImageListViewModel : BaseViewModel
    {
        readonly WeakEventManager<string> _pullToRefreshFailedEventManager = new WeakEventManager<string>();

        bool _isDogImageCollectionRefreshing;
        IReadOnlyList<DogImagesModel> _dogImageList = Array.Empty<DogImagesModel>();

        public DogImageListViewModel()
        {
            RefreshDogCollectionCommand = new AsyncCommand(ExecuteRefreshDogCollectionCommand, _ => !IsDogImageCollectionRefreshing);
        }

        public event EventHandler<string> PullToRefreshFailed
        {
            add => _pullToRefreshFailedEventManager.AddEventHandler(value);
            remove => _pullToRefreshFailedEventManager.RemoveEventHandler(value);
        }

        public IAsyncCommand RefreshDogCollectionCommand { get; }

        public IReadOnlyList<DogImagesModel> DogImageList
        {
            get => _dogImageList;
            set => SetProperty(ref _dogImageList, value);
        }

        public bool IsDogImageCollectionRefreshing
        {
            get => _isDogImageCollectionRefreshing;
            set => SetProperty(ref _isDogImageCollectionRefreshing, value, () => MainThread.BeginInvokeOnMainThread(RefreshDogCollectionCommand.RaiseCanExecuteChanged));
        }

        async Task ExecuteRefreshDogCollectionCommand()
        {
            try
            {
                DogImageList = await GraphQLService.GetDogImages().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                OnPullToRefreshFailed(e.Message);
            }
            finally
            {
                IsDogImageCollectionRefreshing = false;
            }
        }

        void OnPullToRefreshFailed(string errorMessage) => _pullToRefreshFailedEventManager.RaiseEvent(this, errorMessage, nameof(PullToRefreshFailed));
    }
}
