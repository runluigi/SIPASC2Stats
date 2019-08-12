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
    public class IndexModel : PageModel
    {
        private readonly SIPASC2Stats.Models.SIPASC2StatsContext _context;

        public IndexModel(SIPASC2Stats.Models.SIPASC2StatsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FileUpload FileUpload { get; set; }

        public IList<SIPASC2Game> SIPASC2Game { get; private set; }

        public async Task OnGetAsync()
        {
            SIPASC2Game = await _context.SIPASC2Game.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Perform an initial check to catch FileUpload class
            // attribute violations.
            //if (!ModelState.IsValid)
            //{   
            //    SIPAGame = await _context.SIPAGame.AsNoTracking().ToListAsync();
            //    return Page();
            //}

            var ReplayFileData =
                await FileHelpers.ProcessFormFile(FileUpload.ReplayFile, ModelState);

            
            // Perform a second check to catch ProcessFormFile method
            // violations.
            //if (!ModelState.IsValid)
            //{
            //    SIPAGame = await _context.SIPAGame.AsNoTracking().ToListAsync();
            //    return Page();
            //}



            //var file = Path.Combine(_environment.ContentRootPath, "uploads", FileUpload.ReplayFile.FileName);
            /*var file = @"C:\\UploadedReplays\\" + FileUpload.BattleNetID + Path.GetFileName(FileUpload.ReplayFile.FileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await FileUpload.ReplayFile.CopyToAsync(fileStream);
            }*/

            var game = new SIPASC2Game()
            {
                //ID = FileUpload.ReplayFile.FileName,
                BattleNetID = FileUpload.BattleNetID,
                Event_ID = FileUpload.Event_ID,
                Win = FileUpload.Win,
                Map = FileUpload.Map,
                //_context.UserTokens
                ReplayFile = ReplayFileData,
                ReplayFileSize = FileUpload.ReplayFile.Length,
                UploadDT = DateTime.UtcNow
                
            };

            _context.SIPASC2Game.Add(game);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}