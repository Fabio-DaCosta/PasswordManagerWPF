using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _masterkey;
        private readonly IEventAggregator _eventAggregator;

        public LoginViewModel(IEventAggregator eventAggregator, LoginViewModel loginVM)
        {
            _eventAggregator = eventAggregator;
        }

        public string Masterkey
        {
            get { return _masterkey; }
            set { _masterkey = value; }
        }
    }
}
