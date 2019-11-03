namespace RAY.RestClientSample.Views
{
    public partial class MainViewModel
    {
        private string _postText;

        private string _responseText;

        public string ResponseText
        {
            get => _responseText;
            set => SetProperty(ref _responseText, value);
        }

        public string PostText
        {
            get => _postText;
            set => SetProperty(ref _postText, value);
        }
    }
}