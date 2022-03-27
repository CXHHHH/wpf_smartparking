using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class UserModel : BindableBase
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                SetProperty(ref _userName, value);
                System.Diagnostics.Debug.WriteLine(value);
            }
        }

        private string _password = "";
        public string Password
        {
            get { return _password; }
            set
            {
                SetProperty(ref _password, value);
                System.Diagnostics.Debug.WriteLine(value);
            }
        }

    }
}
