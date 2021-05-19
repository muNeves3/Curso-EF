using Agili.Curso.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agili.Curso.EF.Context
{
    public class SemConfiguracaoContext : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<Cartorio> Cartorio { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<TipoTelefone> TipoTelefone { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Produto> Produto { get; set; }

        public SemConfiguracaoContext()
            : base("SemMapMigrations")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<SemConfiguracaoContext>());
        }
    }
}
