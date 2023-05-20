using Business.Models;
using DbContext.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContext.Repository
{
    internal class UsuarioRepository : IUsuarioRepository
    {
        private readonly Context _dbcontext;

        public UsuarioRepository(Context contexto)
        {
            _dbcontext = contexto;
        }
        public Usuario Create()
        {
            throw new NotImplementedException();
        }

        public Usuario Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario Update()
        {
            throw new NotImplementedException();
        }
    }
}
