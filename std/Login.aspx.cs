using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Security;

namespace std
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string Encryption = FormsAuthentication.HashPasswordForStoringInConfigFile(txtpw.Text, "SHA1");
               

                if (Page.IsValid)
                {
                    string connectionstr = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                    using (SqlConnection sqlCon = new SqlConnection(connectionstr))
                    {


                        SqlCommand sqcmd = new SqlCommand("StdProcedure", sqlCon);
                        sqcmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter sqlparam = new SqlParameter();
                        sqlparam.ParameterName = txtfn.Text;

                        if (txtfn.Text != "")
                        {
                            SqlParameter param = new SqlParameter
                                ("@FN", txtfn.Text);
                            sqcmd.Parameters.Add(param);
                        }

                        if (txtfn.Text != "")
                        {
                            SqlParameter param = new SqlParameter
                                ("@LN", txtln.Text);
                            sqcmd.Parameters.Add(param);
                        }

                        if (txtusername.Text != "")
                        {
                            SqlParameter param = new SqlParameter
                                ("@UN", txtusername.Text);
                            sqcmd.Parameters.Add(param);
                        }

                        if (txtemail.Text != "")
                        {
                            SqlParameter param = new SqlParameter
                                ("@Email", txtemail.Text);
                            sqcmd.Parameters.Add(param);
                        }
                        if (txtpw.Text != "")
                        {
                            SqlParameter param = new SqlParameter
                                ("@Pass", Encryption);
                            sqcmd.Parameters.Add(param);
                        }
                        if (ddlcountries.SelectedItem.Value != "null")
                        {
                            SqlParameter param = new SqlParameter
                              ("@Country", ddlcountries.SelectedItem.Text);
                            sqcmd.Parameters.Add(param);
                           
                           
                        }
                        else
                        {
                            lblerrormessage.ForeColor = System.Drawing.Color.Red;
                            lblerrormessage.BackColor = System.Drawing.Color.White;
                            lblerrormessage.Text = "Please Select Your Country";
                        }

                        sqlCon.Open();
                        sqcmd.ExecuteNonQuery();



                    }
                    Response.Redirect("~/userpage.aspx");

                }
            }
            catch (Exception)
            {
               
            }

            

        }

        private void Encrypt(string Password )
        {


        }

        protected void txtemail_TextChanged(object sender, EventArgs e) { }
        
    }
}