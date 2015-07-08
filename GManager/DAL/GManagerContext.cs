using GManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace GManager.DAL
{
    public class GManagerContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public GManagerContext() : base("GManagerDB")
        {

        }
    }
}
