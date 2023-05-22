using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Password { get; set; }
        
        public Contato? Contato { get; set; }
        public EnderecoEntrega EnderecoEntrega { get; set; }
        public ICollection<EnderecoEntrega>? ListaEnderecosEntrega { get; set; }

    }
}
