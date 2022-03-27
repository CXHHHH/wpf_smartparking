using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Models;

namespace Client.ViewModels
{
    public class WinLoginViewModel
    {
        public UserModel UserInfo { get; set; } = new UserModel();

        public WinLoginViewModel()
        {

        }
    }
}
