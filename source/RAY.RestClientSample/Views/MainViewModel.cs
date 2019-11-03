namespace RAY.RestClientSample.Views
{
    using Prism.Commands;
    using Prism.Mvvm;

    public partial class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            CmdRestPost = new DelegateCommand(OnCmdRestPost);
        }
    }
}