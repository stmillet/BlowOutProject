using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOutProject.Models
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        [Required]
        public int InstrumentID { get; set; }

        [Required]
        [Display(Name = "Instrument Type")]
        public string InstType { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string InstDescription { get; set; }

        [Required]
        [Display(Name = "Instrument Price")]
        public double InstPrice { get; set; }

        public int? ClientID { get; set; }
    }
}