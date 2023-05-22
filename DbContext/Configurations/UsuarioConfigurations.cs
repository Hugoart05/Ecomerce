using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Configurations
{
    public class UsuarioConfigurations : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //FluentApi da classe Usuario

            builder.ToTable("TB_USUARIOS");
            builder.Property(a => a.Id)
                .ValueGeneratedOnAdd();

            builder.HasIndex("CPF").IsUnique()
                .HasFilter("[CPF] is not null")
                .HasDatabaseName("IX_CPF_UNIQUE");


            builder.Property(x => x.Name)
                .HasColumnName("NOME")
                .HasMaxLength(64)
                .HasDefaultValue("");


            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(100)
                .HasDefaultValue("");


            builder.HasOne(a => a.Contato)
                .WithOne(cont => cont.UsuarioId)
                .HasForeignKey<Contato>(a => a.UsuarioId);


            builder.HasOne(a => a.EnderecoEntrega)
                .WithOne(end => end.Usuario)
                .HasForeignKey<EnderecoEntrega>(a => a.UsuarioId);
        }
    }
}
