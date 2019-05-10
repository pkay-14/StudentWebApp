using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace stdblog.Models
{
    public class RegisterVM
    {


            public RegisterVM()
            {

            }
            public RegisterVM(tblStudent tbl)
            {
                ID = tbl.ID;
                Name = tbl.First_Name;
                Surname = tbl.Last_Name;
                Username = tbl.User__Name;
                Email = tbl.Email;
                Password = tbl.Password;
                Country = tbl.Country;
            }
            public int ID { get; set; }
            [Required]
            [StringLength(100)]
            public string Name { get; set; }
            [Required]
            [StringLength(100)]
            public string Surname { get; set; }
            [Required]
            [StringLength(100)]
            public string Username { get; set; }
            [Required]
            [StringLength(50)]
            public string Email { get; set; }
            [Required]
            [StringLength(100)]
            public string Password { get; set; }
            [Required]
            [StringLength(100)]
            public string Country { get; set; }
        



    }
}