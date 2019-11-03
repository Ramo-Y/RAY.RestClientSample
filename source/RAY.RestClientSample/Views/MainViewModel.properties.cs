namespace RAY.RestClientSample.Views
{
    using System.Collections.ObjectModel;

    public partial class MainViewModel
    {
        private string _requestUri;

        private ObservableCollection<string> _responseItems;

        public ObservableCollection<string> ResponseItems
        {
            get => _responseItems;
            set => SetProperty(ref _responseItems, value);
        }

        public string RequestUri
        {
            get => _requestUri;
            set => SetProperty(ref _requestUri, value);
        }
    }
}