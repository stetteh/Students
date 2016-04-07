using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [Display(Name="What is your name?")]
        public string Name { get; set; }
    }
}