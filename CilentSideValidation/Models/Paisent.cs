using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CilentSideValidation.Models
{
    public class Paisent
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [Display(Name="User Name")]
        [StringLength(20,ErrorMessage ="Name not be execeed")]
        public string  Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string  ReType { get; set; }
        [Required]
        [Range(18,31,ErrorMessage ="Please enter between 18 to 31")]
        public int age { get; set; }
        [Required]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please enter vaild email")]
        public string  Email { get; set; }


    }
}