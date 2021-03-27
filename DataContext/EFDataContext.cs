using DataContextEntities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataContext
{
    public class EFDataContext : DbContext
    {
        public DbSet<AppCat> cats { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.51;Port=5743;Database=denysdb;Username=denys;Password=qwerty1*;");
        }
    }
}
