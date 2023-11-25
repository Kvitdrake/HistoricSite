using HistoricSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoricSite.Data
{
    public class HistoricSiteContext : DbContext
    {
        public HistoricSiteContext(DbContextOptions<HistoricSiteContext> options)
            : base(options)
        {
        }

        public DbSet<HistoricSite.Models.Place> Place { get; set; } = default!;
    }
}
