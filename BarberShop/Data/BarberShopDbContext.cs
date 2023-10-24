using BarberShop.Model;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.Data
{
    public class BarberShopDbContext : DbContext
    {
        public BarberShopDbContext(DbContextOptions<BarberShopDbContext> options): base(options) 
        { }
        
        public DbSet<Cliente> Clientes { get; set;}

        public DbSet<Agendamento> Agendamentos { get; set;}

        public DbSet<Barbearia> Barbearias { get; set;}

        public DbSet<TipoServico> TipoServicos { get; set;}  

        public DbSet<Administrador> Administradores { get; set; }
    }
}
