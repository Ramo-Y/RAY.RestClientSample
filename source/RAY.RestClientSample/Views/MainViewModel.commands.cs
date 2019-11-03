namespace RAY.RestClientSample.Views
{
    using Prism.Commands;

    public partial class MainViewModel
    {
        public DelegateCommand CmdRestPost { get; }

        private void OnCmdRestPost()
        {
            var requestValue = _restClient.MakeRequest(RequestUri);
            ResponseItems.Add(requestValue);
        }
    }
}