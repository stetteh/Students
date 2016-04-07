using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }
    }
}