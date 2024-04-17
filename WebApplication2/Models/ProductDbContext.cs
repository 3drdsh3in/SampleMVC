using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext()
            : base("XcifySampleTestDB")
        {
        }

        public DbSet<tblProduct> Products { get; set; }

        public static ProductDbContext Create()
        {
            return new ProductDbContext();
        }
    }
}