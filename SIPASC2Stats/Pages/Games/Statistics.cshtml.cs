using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SIPASC2Stats.Models;
using SIPASC2Stats.Utilities;

namespace SIPASC2Stats.Pages.Games
{
    public class StatisticsModel : PageModel
    {
        private readonly SIPASC2Stats.Models.SIPASC2StatsContext _context;
        public IList<SIPASC2Game> SIPASC2Game { get; private set; }
        public StatisticsModel(SIPASC2Stats.Models.SIPASC2StatsContext context){
            _context = context;
        }

        public void OnGet()
        {

        }
    }
}