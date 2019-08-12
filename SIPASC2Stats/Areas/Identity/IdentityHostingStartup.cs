using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SIPASC2Stats.Areas.Identity.Data;
using SIPASC2Stats.Models;

[assembly: HostingStartup(typeof(SIPASC2Stats.Areas.Identity.IdentityHostingStartup))]
namespace SIPASC2Stats.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SIPASC2StatsContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SIPASC2StatsContextConnection")));

                services.AddDefaultIdentity<SIPASC2StatsUser>()
                    .AddEntityFrameworkStores<SIPASC2StatsContext>();
            });
        }
    }
}