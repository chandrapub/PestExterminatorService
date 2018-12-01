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
    public partial class Domestic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowMyCats();
        }

        public void ShowMyCats()
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-F8MV33J\SHEKHARSQL; integrated security = true; database = PestExterminator3rdProject");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MySelectAllPest";

                //rdr = cmd.ExecuteReader();
                //GridViewTotal.DataSource = rdr;
                //GridViewTotal.DataBind();

                //rdr.Close();
                rdr = cmd.ExecuteReader();
                RepeaterPestImage.DataSource = rdr;
                RepeaterPestImage.DataBind();
            }
            catch (Exception ex)
            {
                LabelTotal.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void ButtonSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }

        protected void ButtonSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/signup.aspx");
        }

        protected void RepeaterPestImage_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}