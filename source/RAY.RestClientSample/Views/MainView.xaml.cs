namespace RAY.RestClientSample.Views
{
    using System.Windows.Controls;

    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}