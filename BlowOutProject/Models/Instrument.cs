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
        //This is the instrument Model which matches with the Instrument table in the database

        [Key]
        public int InstrumentID { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string InstDescription { get; set; }

        [Required]
        [Display(Name = "Instrument Type")]
        public string InstType { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal InstPrice { get; set; }

    
        public int? ClientID { get; set; }
    }
}