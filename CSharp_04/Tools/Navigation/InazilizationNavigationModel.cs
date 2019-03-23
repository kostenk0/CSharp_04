using CSharp_04.Views;
using CSharp_04.Windows;
using System;

namespace CSharp_04.Tools.Navigation
{
    internal class InitializationNavigationModel : BaseNavigationModel
    {
        public InitializationNavigationModel(IContentOwner contentOwner) : base(contentOwner)
        {

        }

        protected override void InitializeView(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Input:
                    ViewsDictionary.Add(viewType, new InputWindow());
                    break;
                case ViewType.Main:
                    ViewsDictionary.Add(viewType, new PersonsListView());
                    break;
                case ViewType.Remove:
                    ViewsDictionary.Add(viewType, new RemoveUser());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
            }
        }
    }
}
