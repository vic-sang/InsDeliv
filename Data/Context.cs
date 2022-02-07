#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InsDeliv.Models;

    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<InsDeliv.Models.Item> Item { get; set; }
         public DbSet<InsDeliv.Models.Order> Order { get; set; }
        public DbSet<InsDeliv.Models.Customer> Customer { get; set; }
        public DbSet<InsDeliv.Models.Vendor> Vendor { get; set; }
        public DbSet<InsDeliv.Models.Manager> Manager { get; set; }
        public DbSet<InsDeliv.Models.Shopper> Shopper { get; set; }
    }
