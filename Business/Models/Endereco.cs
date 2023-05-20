using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Endereco
    {
        public int ContatoId { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string TipoResidencia { get; set; }
        public int Numero { get; set; }
        public Usuario Usuario { get; set; }
    }

}
