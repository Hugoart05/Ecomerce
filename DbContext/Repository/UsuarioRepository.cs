using Business.Models;
using DataBase;
using DataBase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repository
{
    internal class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataBaseContext _context;

        public UsuarioRepository(DataBaseContext context)
        {
            _context = context;
        }

        public Usuario Create(Usuario usuario)
        {
           _context.Add(usuario);
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
