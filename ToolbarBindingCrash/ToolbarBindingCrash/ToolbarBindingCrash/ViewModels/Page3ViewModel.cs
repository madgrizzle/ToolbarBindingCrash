using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using ToolbarBindingCrash.Events;

namespace ToolbarBindingCrash.ViewModels
{
    public class Page3ViewModel : BindableBase
    {
        public DelegateCommand PressMeCommand { get; private set; }

        IEventAggregator _ea;

        public Page3ViewModel(IEventAggregator ea)
        {
            _ea = ea;

            PressMeCommand = new DelegateCommand(OnPressMe);
        }

        void OnPressMe()
        {
            _ea.GetEvent<MessageEvent>().Publish("Page 3");
        }
    }
}
