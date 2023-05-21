using Business.Models;
using Business.Produtos;
using DataBase.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options)
        {
                
        }
        DbSet<Usuario> Usuario { get; set; }
        DbSet<EnderecoEntrega> Endereco { get; set; }
        DbSet<Produto> Produto { get; set; }
        DbSet<FornecedorProduto> FornecedorProduto { get; set; }
        DbSet<CategoriaProduto> Categoria { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfigurations());
        }
    }
}
