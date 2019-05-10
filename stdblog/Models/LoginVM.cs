using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace stdblog.Models
{
    public class LoginVM
    {
        [Required]
        [StringLength(100)]
        public string Username { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
       
    }
}