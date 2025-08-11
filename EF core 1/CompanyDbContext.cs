using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_core_1
{
    internal class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base()
        {
          
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Do Nothing=>inhearted to use it as connection string
        {
            optionsBuilder.UseSqlServer(" Server = .; Database = CompanyDb ; Trusted_Connection = true ; TrustServerCertificate = true"); //connection string
        }

        //DbSet

        public DbSet<Employee> Emmployees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Player> Players { get; set; }



    }
}
