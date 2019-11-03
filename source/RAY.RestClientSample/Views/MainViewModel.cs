namespace RAY.RestClientSample.Views
{
    using System.Collections.ObjectModel;

    using Prism.Commands;
    using Prism.Mvvm;

    public partial class MainViewModel : BindableBase
    {
        private readonly RestClient _restClient;

        public MainViewModel()
        {
            CmdRestPost = new DelegateCommand(OnCmdRestPost);
            ResponseItems = new ObservableCollection<string>();
            _restClient = new RestClient();
        }
    }
}