using CSharp_04.Tools.Navigation;
using CSharp_04.ViewModels;
using System.Windows.Controls;

namespace CSharp_04.Views
{
    /// <summary>
    /// Interaction logic for InputWindow.xaml
    /// </summary>
    public partial class InputWindow : UserControl, INavigatable
    {

        public InputWindow()
        {
            InitializeComponent();
            DataContext = new InputViewModel();
        }
    }
}
