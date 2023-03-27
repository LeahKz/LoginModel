using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Windows.Input;

namespace POS_NT.ViewModel_NT
{
    public class LogginVMNT : ViewModelBase
    {
        //Fields view
        private string _username;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible=true;

        //Properties 
        public string Username
        {
            get 
            { 
                return _username; 
            }
            set
            {_username = value; OnPropertyChanged(nameof(Username));}

        }
        public SecureString Password
        {
            get {return _password;}
            set 
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ErrorMessage
        {
            get {return _errorMessage;}
            set { _errorMessage = value; OnPropertyChanged(nameof(ErrorMessage)); }
        }
        public bool IsViewVisible
        {
            get { return _isViewVisible;}
            set { _isViewVisible = value; OnPropertyChanged(nameof(IsViewVisible)); }
        }


    }
}
