using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Maths
    {
        [Display(Name= "Enter First Number")]
        public decimal firstnum { get; set; }
        [Display (Name ="Enter Second Number")]
        public decimal secondnum { get; set; }
    }
}