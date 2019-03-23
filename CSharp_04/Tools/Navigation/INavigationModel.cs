using CSharp_04.Models;
using System;

namespace CSharp_04.Tools.Navigation
{
    internal enum ViewType
    {
        Input,
        Main,
        Remove
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
        void Navigate(ViewType viewType, bool refresh);
        void Navigate(ViewType viewType, String buttonName);
        void Navigate(ViewType viewType, Person person);
    }
}
