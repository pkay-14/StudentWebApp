using System;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace std
{
    public partial class frontpagelogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string Encryption = FormsAuthentication.HashPasswordForStoringInConfigFile(txtloginpassword.Text, "SHA1");
            if (returnValue(txtloginusername.Text, Encryption))
            {
                Response.Redirect("~/userpage.aspx");
                
            }
            else
            {
                lblmessage.Text = "Invalid username or password";
            }
        }

        private bool returnValue(string Usernam, string Pass)
        {

            string connectionstring = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                SqlCommand sqlcommand = new SqlCommand("[validator]", sqlcon);
                sqlcommand.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter("@username", Usernam);
                SqlParameter parameter2 = new SqlParameter("@userpassword", Pass);

                sqlcommand.Parameters.Add(parameter);
                sqlcommand.Parameters.Add(parameter2);
                
               

                sqlcon.Open();
                int userindatabase = (int)sqlcommand.ExecuteScalar();
                return userindatabase == 1;
            }
        }

        protected void txtloginpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
