using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOutProject.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public String CLientFirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public String ClientLastName { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        public String ClientAddress { get; set; }
        [Required]
        [Display(Name = "City")]
        public String ClientCity { get; set; }
        [Required]
        [Display(Name = "Zip Code")]
        public int ClientZipCode { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public String ClientEmail { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public String CLientPhone { get; set; }
    }
}