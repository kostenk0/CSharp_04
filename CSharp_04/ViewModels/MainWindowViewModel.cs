using CSharp_04.Tools;
using CSharp_04.Tools.Managers;

namespace CSharp_04.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel, ILoaderOwner
    {
        private bool _isControlEnabled = true;

        public bool IsControlEnabled
        {
            get { return _isControlEnabled; }
            set
            {
                _isControlEnabled = value;
                OnPropertyChanged();
            }
        }

        internal MainWindowViewModel()
        {
            LoaderManeger.Instance.Initialize(this);
        }
    }
}
