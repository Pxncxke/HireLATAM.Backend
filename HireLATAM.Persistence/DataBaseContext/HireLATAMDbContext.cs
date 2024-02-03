using HireLATAM.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireLATAM.Persistence.DataBaseContext
{
    public class HireLATAMDbContext : DbContext
    {
        public HireLATAMDbContext(DbContextOptions<HireLATAMDbContext> options) : base(options)
        {
            
        }

        public DbSet<Item> Items { get; set; }
    }
}
