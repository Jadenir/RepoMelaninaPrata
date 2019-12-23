using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;

namespace Models.DAL
{
    class MeuContexto : DbContext
    {
        public MeuContexto() : base("DBMelanina")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MeuContexto>());
        }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
