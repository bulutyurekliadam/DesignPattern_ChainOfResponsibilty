using DesignPattern_ChainOfResponsibilty.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern_ChainOfResponsibilty.DAL.Context
{
    public class ChainOfRespContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-H67U406;initial Catalog=DbChainOfResponsibility;integrated Security =true");

        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
