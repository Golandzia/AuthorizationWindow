using AuthorizationWindow.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationWindow.ViewModel
{
    public class MainWindowVM : INotifyPropertyChanged
    {

        private string _login;
        public string login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
                OnPropertyChanged("Login");
            }
        }

        private string _password;
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
        User user = new User();
        //public bool isAuthorizationSuccessfull { get; } => 

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}