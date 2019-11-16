using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOutProject.Models
{
    public class Instrument
    {
        //initialize instrument object attributes
        public string Name { get; set; }

        [Display(Name = "Used Price")]
        public string PriceUsed { get; set; }
        [Display(Name = "New Price")]
        public string PriceNew { get; set; }

        //determine and initialize used and new prices
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