using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SIPASC2Stats.Models
{
    public class FileUpload
    {
        [Required]
        [Display(Name = "ID")]
        [StringLength(60, MinimumLength = 3)]
        public string ID { get; set; }

        [Required]
        [Display(Name = "BattleNetID")]
        [StringLength(60, MinimumLength = 3)]
        public string BattleNetID { get; set; }

//        [Required]
        [Display(Name = "Event ID")]
        [StringLength(60, MinimumLength = 1)]
        public string Event_ID { get; set; }

        [Display(Name = "Chicken Dinner")]
        public bool Win { get; set; }

        [Display(Name = "Map")]
        public string Map { get; set; }

        [Required]
        [Display(Name = "Replay File")]
        public IFormFile ReplayFile { get; set; }

    }
}
