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
        public int EnderecoId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Password { get; set; }
        
        public Contato? Contato { get; set; }
        public ICollection<Endereco>? EnderecosEntrega { get; set; }

    }
}
