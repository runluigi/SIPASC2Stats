using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPASC2Stats.Models
{
    public class SIPAEvent
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Uploaded (UTC)")]
        [DisplayFormat(DataFormatString = "{0:F}")]
        public DateTime ScheduleDT { get; set; }
        public byte[] ThumbImage { get; set; }

    }
}
