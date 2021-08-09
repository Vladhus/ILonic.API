using ILonic.API.DTO;
using ILonic.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILonic.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TempData>().HasData(
                                  new TempData {ID = 1,Number = "48 794 559 395", Date = DateTime.Now.ToLocalTime(),Amount = 5},
                                  new TempData {ID = 2,Number = "48 794 559 395", Date = DateTime.Now.ToLocalTime(),Amount = 9},
                                  new TempData {ID = 3,Number = "48 794 559 395", Date = DateTime.Now.ToLocalTime(),Amount = 10},
                                  new TempData {ID = 4,Number = "48 794 559 395", Date = DateTime.Now.ToLocalTime(),Amount = 11},
                                  new TempData {ID = 5,Number = "48 794 559 395", Date = DateTime.Now.ToLocalTime(),Amount = 29}
                                  );
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TempData> TempDatas { get; set; }
    }
}
