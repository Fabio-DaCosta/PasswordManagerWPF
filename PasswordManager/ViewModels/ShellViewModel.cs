using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private readonly LoginViewModel _loginVM;
        private readonly IEventAggregator _eventAggregator;
        public ShellViewModel(IEventAggregator eventAggregator, LoginViewModel loginVM)
        {
            _eventAggregator = eventAggregator;
            _loginVM = loginVM;
            ActivateItem(_loginVM);
        }
    }
}
