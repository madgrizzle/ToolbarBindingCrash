using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ToolbarBindingCrash.ViewModels
{
    public class TabbedPageViewModel : BindableBase, INavigationAware
    {
        public TabbedPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
