using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using AsyncAwaitBestPractices;
using AsyncAwaitBestPractices.MVVM;
using DotNetGraphQL.Common;
using GraphQL.Client.Http;
using GraphQL.Common.Request;
using GraphQL.Common.Response;
using Xamarin.Forms;

namespace DotNetGraphQL.Mobile
{
    class DogImageListViewModel : BaseViewModel
    {
        readonly WeakEventManager<string> _pullToRefreshFailedEventManager = new WeakEventManager<string>();

        bool _isDogImageCollectionRefreshing;

        public DogImageListViewModel()
        {
            RefreshDogCollectionCommand = new AsyncCommand(ExecuteRefreshDogCollectionCommand, _ => !IsDogImageCollectionRefreshing);
        }

        public event EventHandler<string> PullToRefreshFailed
        {
            add => _pullToRefreshFailedEventManager.AddEventHandler(value);
            remove => _pullToRefreshFailedEventManager.RemoveEventHandler(value);
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
                //Todo Get Dogs from GraphQL Backend
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

        void OnPullToRefreshFailed(string errorMessage) => _pullToRefreshFailedEventManager.HandleEvent(this, errorMessage, nameof(PullToRefreshFailed));
    }
}
