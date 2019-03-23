using System.ComponentModel;

namespace CSharp_04.Tools
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        bool IsControlEnabled { get; set; }
    }
}
