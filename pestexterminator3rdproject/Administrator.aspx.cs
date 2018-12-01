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
    public partial class Administrator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CrudGridview();
                //ButtonCreate.Enabled = false;
                ButtonUpdate.Enabled = false;
                ButtonDelete.Enabled = false;

            }

            //CrudGridview();
            DropDownListAdmin.AutoPostBack = true;
        }
        public void CrudGridview()
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-F8MV33J\SHEKHARSQL; integrated security = true; database = PestExterminator3rdProject");
            SqlDataAdapter da = null;
            DataSet ds = null;
            DataTable dt = null;
            SqlCommand cmd = null;
            string sqlsel = "select * from pestinfo";
            //string sqlins = "insert into Pest values (@PestName, @ControlPrice, @PestPhoto)";

            try
            {
                //conn.Open(); SqlDataAdapter opens connection by itself
                
                

                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sqlsel, conn);

                ds = new DataSet();
                da.Fill(ds, "MyPests");

                dt = ds.Tables["MyPests"];

                GridViewAdmin.DataSource = dt;
                GridViewAdmin.DataBind();
                //Drop Down list for Delete action
                DropDownListAdmin.DataSource = dt;
                DropDownListAdmin.DataTextField = "PestName";
                DropDownListAdmin.DataValueField = "PestID";
                DropDownListAdmin.DataBind();
                DropDownListAdmin.Items.Insert(0, "Select a Pest");

                //DataRow newrow = dt.NewRow();
                //newrow["PestName"] = TextBox1.Text;
                //newrow["ControlPrice"] = TextBox2.Text;
                //newrow["PestPhoto"] = TextBox3.Text;



                //dt.Rows.Add(newrow);

                ////cmd = new SqlCommand(sqlins, conn);
                //cmd.Parameters.Add("@PestName", SqlDbType.Text, 50, "PestName");
                //cmd.Parameters.Add("@ControlPrice", SqlDbType.Text, 50, "ControlPrice");
                //cmd.Parameters.Add("@PestPhoto", SqlDbType.Text, 50, "PestPhoto");



                //da.InsertCommand = cmd;
                //da.Update(ds, "MyPests");


                LabelError.Text = "New Pest added";


            }
            catch (Exception ex)
            {
                LabelError.Text = ex.Message;
            }
            finally
            {
                conn.Close(); // SqlDataAdapter closes connection by itself; but can fail in case of errors
            }
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-F8MV33J\SHEKHARSQL; integrated security = true; database = PestExterminator3rdProject");
            SqlDataAdapter da = null;
            DataSet ds = null;
            DataTable dt = null;
            SqlCommand cmd = null;

            string sqlsel = "select * from Pestinfo";
            string sqlins = "insert into Pestinfo values (@PestName, @PestPrice, @Picture)";

            try
            {
                //conn.Open();
                
                

                da = new SqlDataAdapter();
                

                da.SelectCommand = new SqlCommand(sqlsel, conn);

                ds = new DataSet();

                da.Fill(ds, "MyPests");

                dt = ds.Tables["MyPests"];



                DataRow newrow = dt.NewRow();
                newrow["PestName"] = TextBoxName.Text;
                TextBoxName.Text = " ";
                newrow["PestPrice"] = TextBoxPrice.Text;
                TextBoxPrice.Text = " ";
                newrow["Picture"] = TextBoxPicture.Text;
                TextBoxPicture.Text = " ";
                


                dt.Rows.Add(newrow);
                

                cmd = new SqlCommand(sqlins, conn);
                cmd.Parameters.Add("@PestName", SqlDbType.Text, 50, "PestName");
                cmd.Parameters.Add("@PestPrice", SqlDbType.Decimal, 2, "PestPrice");
                cmd.Parameters.Add("@Picture", SqlDbType.Text, 50, "Picture");

               
                da.InsertCommand = cmd;
                da.Update(ds, "MyPests");
                //ButtonCreate.Enabled = true;
                CrudGridview();


                LabelError.Text = "New Pest added";
            }
            catch (Exception ex)
            {
                LabelError.Text = ex.Message;
            }
            finally
            {
                conn.Close();

            }
        }

        protected void GridViewAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxName.Text = GridViewAdmin.SelectedRow.Cells[2].Text;
            TextBoxPrice.Text = GridViewAdmin.SelectedRow.Cells[3].Text;
            TextBoxPicture.Text = GridViewAdmin.SelectedRow.Cells[4].Text;

            LabelError.Text = "You chose pest " + GridViewAdmin.SelectedRow.Cells[1].Text;
            ButtonUpdate.Enabled = true;
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-F8MV33J\SHEKHARSQL; integrated security = true; database = PestExterminator3rdProject");
            SqlDataAdapter da = null;
            DataSet ds = null;
            DataTable dt = null;
            SqlCommand cmd = null;
            string sqlsel = "select * from pestinfo";
            string sqlupd = "update pestinfo set PestName = @PestName, PestPrice = @PestPrice,Picture=@Picture where PestID = @PestID";

            try
            {
                //conn.Open();
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sqlsel, conn);

                ds = new DataSet();
                da.Fill(ds, "MyPests");

                dt = ds.Tables["MyPests"];

                int tableindex = GridViewAdmin.SelectedIndex;
                dt.Rows[tableindex]["PestName"] = TextBoxName.Text;
                TextBoxName.Text = "";
                dt.Rows[tableindex]["PestPrice"] = TextBoxPrice.Text;
                TextBoxPrice.Text = "";
                dt.Rows[tableindex]["Picture"] = TextBoxPicture.Text;
                TextBoxPicture.Text = "";


                cmd = new SqlCommand(sqlupd, conn);
                cmd.Parameters.Add("@PestName", SqlDbType.Text, 50, "PestName");
                cmd.Parameters.Add("@PestPrice", SqlDbType.Decimal, 2, "PestPrice");
                cmd.Parameters.Add("@Picture", SqlDbType.Text, 50, "Picture");

                SqlParameter myparm = cmd.Parameters.Add("@PestID", SqlDbType.Int, 4, "PestID");
                myparm.SourceVersion = DataRowVersion.Original; // good habit if someone changes the primary key

                da.UpdateCommand = cmd;
                da.Update(ds, "MyPests");

                LabelError.Text = "Update of Pest " + GridViewAdmin.SelectedRow.Cells[1].Text;
            }
            catch (Exception ex)
            {
                LabelError.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            CrudGridview();
        }

        protected void DropDownListAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListAdmin.SelectedIndex != 0)
            {
                LabelError.Text = "You chose Pest " + DropDownListAdmin.SelectedValue;
                ButtonDelete.Enabled = true;
            }
            else
            {
                LabelError.Text = "You chose none";
                ButtonDelete.Enabled = false;
            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = PestExterminator3rdProject");
            SqlDataAdapter da = null;
            SqlCommandBuilder cb = null;
            DataSet ds = null;
            DataTable dt = null;
            string sqlsel = "select * from pestinfo";

            try
            {
                //conn.Open();
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sqlsel, conn);

                cb = new SqlCommandBuilder(da);

                ds = new DataSet();
                da.Fill(ds, "MyPests");

                dt = ds.Tables["MyPests"];

                foreach (DataRow myrow in dt.Select("PestID =" + Convert.ToInt32(DropDownListAdmin.SelectedValue)))
                {
                    myrow.Delete();
                }

                da.Update(ds, "MyPests");

                LabelError.Text = "Pest " + DropDownListAdmin.SelectedValue + " deleted";
                ButtonDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                LabelError.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            CrudGridview();
        }

        protected void Buttonlogout_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("~/Login.aspx");
        }
    }
    }

    
    
