using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stdblog.Models
{
    public class LoginRegisterVM
    {

        public RegisterVM registervm { get; set; }
        public LoginVM loginvm { get; set; }

        public bool bIsActionLogin{ get; set; }
        public bool bIsActionRegister { get; set; }
        public string sReturnUrl { get; set; }


        public void IsActionRegister()

        {
            bIsActionLogin = false;
            bIsActionRegister = true;
        }

        public void IsActionLogin()

        {
            bIsActionLogin = true;
            bIsActionRegister= false;
        }
    }
}