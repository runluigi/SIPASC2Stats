using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPASC2Stats.Models
{
    public class SIPAGame
    {
        public string ID { get; set; }
        public string BattleNetID { get; set; }

        public string ReplayFile { get; set; }

        [Display(Name = "File Size (bytes)")]
        [DisplayFormat(DataFormatString = "{0:N1}")]
        public long ReplayFileSize { get; set; }

        [Display(Name = "Uploaded (UTC)")]
        [DisplayFormat(DataFormatString = "{0:F}")]
        public DateTime UploadDT { get; set; }
    }
}
