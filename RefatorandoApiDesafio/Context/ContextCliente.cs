using Microsoft.EntityFrameworkCore;
using RefatorandoApiDesafio.Models;

namespace RefatorandoApiDesafio.Context
{
    public class ContextCliente : DbContext
    {


        public ContextCliente(DbContextOptions<ContextCliente> options)
            : base(options)
        { }

        public DbSet<Cliente> Cliente { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(c =>
            {
                c.ToTable("Cliente");
                c.HasKey(p => p.Cpf);

            });
           

        }
    }
}
