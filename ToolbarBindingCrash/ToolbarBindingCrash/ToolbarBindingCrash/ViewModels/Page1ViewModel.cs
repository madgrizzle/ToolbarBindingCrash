using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using ToolbarBindingCrash.Events;

namespace ToolbarBindingCrash.ViewModels
{
    public class Page1ViewModel : BindableBase
    {
        private string _toolbarText;
        public string ToolbarText
        {
            get { return _toolbarText; }
            set { SetProperty(ref _toolbarText, value); }
        }

        IEventAggregator _ea;

        public Page1ViewModel(IEventAggregator ea)
        {
            _ea = ea;
            _toolbarText = "Default Text";

            _ea.GetEvent<MessageEvent>().Subscribe(ProcessEvent);
        }

        void ProcessEvent(string message)
        {
            ToolbarText = message; //this, I believe, will result in a crash.
        }
        
    }
}
