using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Login
{
    class Login : Usuario
    {
        public Login()
        {

        }
        public string Email => base.Email;
        public string Password => base.Password;

    }
}
