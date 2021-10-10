using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SellingSunsets.Models;

namespace SellingSunsets.Data
{
    public class SellingSunsetsContext : DbContext
    {
        public SellingSunsetsContext (DbContextOptions<SellingSunsetsContext> options)
            : base(options)
        {
        }

        public DbSet<SellingSunsets.Models.Agent> Agent { get; set; }

        public DbSet<SellingSunsets.Models.City> City { get; set; }

        public DbSet<SellingSunsets.Models.Dwelling> Dwelling { get; set; }

        public DbSet<SellingSunsets.Models.SalesOffice> SalesOffice { get; set; }
    }
}
