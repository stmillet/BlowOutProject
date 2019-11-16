using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOutProject.Models
{
    public class Instrument
    {
        public string Name { get; set; }

        [Display(Name = "Used Price")]
        public string PriceUsed { get; set; }
        [Display(Name = "New Price")]
        public string PriceNew { get; set; }

        public string CalcPriceUsed()
        {
            return this.PriceUsed;
        }

        public string CalcPriceNew()
        {
            return this.PriceNew;
        }
    }
}