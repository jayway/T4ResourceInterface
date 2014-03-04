// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StringResourceDemo.Views
{
    using Windows.UI.Xaml.Controls;
    using Services;
    using Strings;
    using ViewModels;

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new MainVM(new StringResources(), new LocalKeyValueStore());
        }
    }
}
