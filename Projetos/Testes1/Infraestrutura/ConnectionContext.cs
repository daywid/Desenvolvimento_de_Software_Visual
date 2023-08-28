using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Testes1.Model;

namespace Testes1.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "Server=localhost;" +
            "Port=5432;Database=webAPI-Tests;" +
            "User Id=postgres;" + 
            "Password=postgres;");
    }
}