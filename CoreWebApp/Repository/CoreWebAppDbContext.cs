using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;    
using System.Threading.Tasks;
using CoreWebApp.Models;

namespace CoreWebApp.Repository
{
    public partial class CoreWebAppDbContext : DbContext
    {
        public CoreWebAppDbContext()
        {
        }

        public CoreWebAppDbContext(DbContextOptions<CoreWebAppDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<ProductModel> Product { get; set; }
        public virtual DbSet<Student> Student { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }



    }
}
