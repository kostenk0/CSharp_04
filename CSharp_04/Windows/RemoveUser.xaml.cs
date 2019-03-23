using CSharp_04.Tools.Navigation;
using CSharp_04.ViewModels;
using System.Windows.Controls;

namespace CSharp_04.Windows
{
    /// <summary>
    /// Interaction logic for RemoveUser.xaml
    /// </summary>
    public partial class RemoveUser : UserControl, INavigatable
    {
        public RemoveUser()
        {
            InitializeComponent();
            DataContext = new RemovePersonViewModel();
        }
    }
}
