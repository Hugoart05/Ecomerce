using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContext.Repository
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        Usuario Get(int id);
        Usuario Update();
        Usuario Delete(int id);
        Usuario Create();
    }
}
