using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace std
{
    public partial class userpage : System.Web.UI.Page
    {
        string username = "testuser1";
        protected void Page_Load(object sender, EventArgs e)
        {
          
           
        }


        protected void btnuploadimg_Click(object sender, EventArgs e)
        {
            
            FileUpload1.Visible = true;
            if (FileUpload1.HasFile)
            {
                saveintodb();
                uploadimg();
            }
            
            
            
           
        }
        private void saveintodb()
        {
            HttpPostedFile postedFile = FileUpload1.PostedFile;
            string filename = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(filename);
            int filesize = postedFile.ContentLength;
          // if (fileExtension == "jpg" || fileExtension == "png")
            //{
               Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                byte[] bytes = binaryReader.ReadBytes((int)stream.Length);

                string connectionstring = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("updateimgprocedure", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramImg = new SqlParameter()
                    {
                        ParameterName = "@profilepic",
                        Value = bytes,

                    };
                    SqlParameter paramName = new SqlParameter()
                    {
                        ParameterName = "@username",
                        Value = username,

                    };
                    cmd.Parameters.Add(paramImg);
                    cmd.Parameters.Add(paramName);
                    //cmd.Parameters.AddWithValue("@profile", bytes);
                    //cmd.Parameters.AddWithValue("@username", "pkay14");



                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                   
                }
            //}
        }
        private void uploadimg()
        {
           
            string connectionstring = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("uploadprocedure", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramImg = new SqlParameter()
                {
                    ParameterName = "@username",
                    Value = username,

                };
               
                cmd.Parameters.Add(paramImg);
                sqlConnection.Open();

                byte[] bytes = (byte[])cmd.ExecuteScalar();
                string str = Convert.ToBase64String(bytes);
                imgavatar.ImageUrl = "data: Image/png;base64," + str;
                FileUpload1.Visible = false;
            }
        }

        protected void txtsearchbox_TextChanged(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("searchuser", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramsearch = new SqlParameter()
                {
                    ParameterName = "@usersearch",
                    Value = txtsearchbox.Text,
                };
                cmd.Parameters.Add(paramsearch);
                sqlConnection.Open();
            }
            }
    }

   
}