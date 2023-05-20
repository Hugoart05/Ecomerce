using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Models;

namespace DbContext.DbContext
{
    public class Context
    {
        
        public Context() { }

        DbSet<Usuario> Usuario { get; set; }
        DbSet<Endereco> Endereco { get; set; }

    }
}
