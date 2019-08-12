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

namespace SIPASC2Stats.Pages.Events
{
    public class NewEventModel : PageModel{

        private readonly SIPASC2Stats.Models.SIPASC2StatsContext _context;

        [BindProperty]
        public SIPAEventUpload SIPAEventUpload { get; set; }

        public IList<SIPAEvent> SIPAEvent { get; private set; }

        public NewEventModel(SIPASC2Stats.Models.SIPASC2StatsContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(){
            SIPAEvent = await _context.SIPAEvent.AsNoTracking().ToListAsync();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            //var ReplayFileData =await FileHelpers.ProcessFormFile(FileUpload.ReplayFile, ModelState);

            //var file = Path.Combine(_environment.ContentRootPath, "uploads", FileUpload.ReplayFile.FileName);
            /*var file = @"C:\\UploadedReplays\\" + FileUpload.BattleNetID + Path.GetFileName(FileUpload.ReplayFile.FileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await FileUpload.ReplayFile.CopyToAsync(fileStream);
            }*/

            var sipaevent = new SIPAEvent()
            {
                //ID = FileUpload.ReplayFile.FileName,
                Name = SIPAEventUpload.Name,
                Description = SIPAEventUpload.Description,
                ScheduleDT = SIPAEventUpload.ScheduleDT,
                //ThumbImage = SIPAEventUpload.ThumbFile
                //UploadDT = DateTime.UtcNow
            };

            using (var memoryStream = new MemoryStream())
            {
                await SIPAEventUpload.ThumbFile.CopyToAsync(memoryStream);
                sipaevent.ThumbImage = memoryStream.ToArray();
            }

            _context.SIPAEvent.Add(sipaevent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./NewEvent");
        }
    }
}