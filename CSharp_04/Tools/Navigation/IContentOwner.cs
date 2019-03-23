using System.Windows.Controls;

namespace CSharp_04.Tools.Navigation
{
    internal interface IContentOwner
    {
        ContentControl ContentControl { get; }
    }
}
