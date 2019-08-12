using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace SIPASC2Stats.Models
{
    public class SIPAEventUpload{
        [Required]
        [Display(Name = "ID")]
        [StringLength(60, MinimumLength = 3)]
        public string ID { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(255, MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [StringLength(300, MinimumLength = 1)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Date Time (CT)")]
        [DisplayFormat(DataFormatString = "{0:F}")]
        public DateTime ScheduleDT { get; set; }

        [Required]
        [Display(Name = "Thumb Image")]
        public IFormFile ThumbFile { get; set; }
        //Microsoft.AspNetCore.Http.d

    }
}
