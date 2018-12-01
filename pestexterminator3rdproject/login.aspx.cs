using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace pestexterminator3rdproject
{
    public partial class login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = PestExterminator3rdProject"); // making connection   
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE Email='" + TextBoxEmail.Text + "' AND Password='" + TextBoxPassword.Text + "'", con);
            ///* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */

            //DataTable dt = new DataTable(); //this is creating a virtual table  
            //sda.Fill(dt);

            //if (dt.Rows[0][0].ToString() == "1")
            //{
            //    /*If the user is successfully authenticated then the form will be moved to the next form */

            //    this.Visible = false;
            //    Administrator home = new Administrator();
            //    home.Visible = true;




            //}
            //else
            //    LabelMessage.Text = "Invalid Password";

            //***********************************************
            SqlConnection con = new SqlConnection(@"data source = DESKTOP-F8MV33J\SHEKHARSQL; integrated security = true; database = PestExterminator3rdProject");

            string query = "SELECT COUNT(*) FROM login WHERE Email=@Email AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@Email", TextBoxEmail.Text));
            cmd.Parameters.Add(new SqlParameter("@password", TextBoxPassword.Text));


            con.Open();

            string output = cmd.ExecuteScalar().ToString();

            if (output == "1")
            {
                //Creating a session for the user

                
                   
                
                Session["login"] = TextBoxEmail.Text;


                Response.Redirect("Administrator.aspx");
            }
            else
            {
                Response.Write("Login failed.");
            }
        }

        protected void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}