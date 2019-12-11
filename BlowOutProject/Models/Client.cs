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
        [Required]
        public int ClientID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string ClientFirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string ClientLastName { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string ClientAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string ClientCity { get; set; }

        [Required]
        [Display(Name = "State")]
        public string ClientState { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public int ClientZipCode { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string ClientEmail { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string ClientPhone { get; set; }
    }
}