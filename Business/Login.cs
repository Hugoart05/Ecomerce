using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class Login : Usuario
    {
        public string Email => base.Email;
        public string Password => base.Password;

    }
}
