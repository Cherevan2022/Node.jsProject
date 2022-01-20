using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        // props
        public DbSet<Computer> Computers { get; set; }
        public DbSet<CPU> Cpus { get; set; }
        public DbSet<GPU> Gpus { get; set; }
        public DbSet<RAM> Rams { get; set; }

        // ctor
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
    }
}
