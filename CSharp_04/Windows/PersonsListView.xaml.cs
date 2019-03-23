using CSharp_04.Tools.Navigation;
using CSharp_04.ViewModels;
using System.Windows.Controls;

namespace CSharp_04.Windows
{
    /// <summary>
    /// Interaction logic for PersonsListView.xaml
    /// </summary>
    public partial class PersonsListView : UserControl, INavigatable
    {
        public PersonsListView()
        {
            InitializeComponent();
            DataContext = new PersonsListViewModel();
            this.myGrid.IsReadOnly = true;
        }

    }
}
