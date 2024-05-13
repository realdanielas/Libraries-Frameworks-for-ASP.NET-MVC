using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace AplicacionDeCodigo.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        { }

        public DbSet<Ventas> ventas { get; set; }
    }
}
