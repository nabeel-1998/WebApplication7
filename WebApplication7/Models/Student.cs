using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Student
    {
        [Required (ErrorMessage ="Student Id is required")] 
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string  Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Contact is required")]
        public string Contact{ get; set; }
    }
}