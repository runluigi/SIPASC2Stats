using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SIPASC2Stats.Areas.Identity.Data;

namespace SIPASC2Stats.Models
{
    public class SIPASC2StatsContext : IdentityDbContext<SIPASC2StatsUser>
    {
        public SIPASC2StatsContext(DbContextOptions<SIPASC2StatsContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        //public DbSet<SIPAGame> SIPAGame { get; set; }
        public DbSet<SIPASC2Game> SIPASC2Game { get; set; }
        public DbSet<SIPAEvent> SIPAEvent { get; set; }

    }
}
