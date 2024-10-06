using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagement2.Models
{
    public class Login
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}