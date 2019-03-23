using CSharp_04.Tools.DataStorage;
using CSharp_04.Tools.Managers;
using CSharp_04.Tools.Navigation;
using CSharp_04.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace CSharp_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IContentOwner
    {

        public MainWindow()
        {
            InitializeComponent();
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
                return;
            DataContext = new MainWindowViewModel();
            InitializeApplication();
        }

        public ContentControl ContentControl => _contentControl;

        private void InitializeApplication()
        {
            StationManager.Initialize(new SerializedDataStorage());
            NavigationManager.Instance.Initialize(new InitializationNavigationModel(this));
            NavigationManager.Instance.Navigate(ViewType.Main);
        }
    }
}
