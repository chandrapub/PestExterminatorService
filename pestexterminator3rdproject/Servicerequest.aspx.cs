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
    public partial class Servicerequest : System.Web.UI.Page

    { public void updateGrid()
        { //Connection String
            string connString = @"data source = DESKTOP-F8MV33J\SHEKHARSQL; integrated security = true; database = PestExterminator3rdProject";

            //Query
            string sql = @"SELECT PestName,ServicePeriod,Date FROM requestinfo1 ";

            //Create Connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //Open Connection
                conn.Open();

                //Create Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create data reader
                SqlDataReader rdr = cmd.ExecuteReader();




                GridViewRequest.DataSource = rdr;
                GridViewRequest.DataBind();

                //close Reader
                rdr.Close();

            }
            catch (Exception ex)
            {
                LabelOrder.Text = ex.Message;
            }
            finally
            {
                conn.Close(); // SqlDataAdapter closes connection by itself; but can fail in case of errors
            }
        }

        /* public void updateGrid()
         {
             SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = PestExterminator3rdProject");
             SqlDataAdapter da2 = null;
             DataSet ds2 = null;
             DataTable dt2 = null;
             SqlCommand cmd = null;
             //string sqlsel = "select * from pestinfo";
             string sqlins = "insert into reguestinfo values(@PestName)";

             try
             {
                 //conn.Open(); SqlDataAdapter opens connection by itself



                 da2 = new SqlDataAdapter();
                 da2.SelectCommand = new SqlCommand(sqlins, conn);

                 ds2 = new DataSet();
                 da2.Fill(ds2, "MyService");

                 dt2 = ds2.Tables["MyService"];

                 GridViewRequest.DataSource = dt2;
                 GridViewRequest.DataBind();
                 //Drop Down list for Delete action
                 //DropDownListAdmin.DataSource = dt;
                 //DropDownListAdmin.DataTextField = "PestName";
                 //DropDownListAdmin.DataValueField = "PestID";
                 //DropDownListAdmin.DataBind();
                 //DropDownListAdmin.Items.Insert(0, "Select a Pest");

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


                 LabelOrder.Text = "New Pest added";


             }
             catch (Exception ex)
             {
                 LabelOrder.Text = ex.Message;
             }
             finally
             {
                 conn.Close(); // SqlDataAdapter closes connection by itself; but can fail in case of errors
             }
         }*/
        protected void Page_Load(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = PestExterminator3rdProject");
            string com = "Select   PestName from pestinfo ";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DropDownListPestName.DataSource = dt;
            //DropDownListPestName.DataBind();
            DropDownListPestName.DataTextField = "PestName";
            //DropDownListPestName.DataValueField = "ID";
            DropDownListPestName.DataBind();
           
            //DropDownListPestName.Items.Insert(0, "Select a Pest");
            //****************************************
            string sqlsel = "Select   ServicePeriod from servicetimeinfo ";
            SqlDataAdapter adpt1 = new SqlDataAdapter(sqlsel, con);
            DataTable dt1 = new DataTable();
            adpt1.Fill(dt1);
            DropDownListTime.DataSource = dt1;
            //DropDownListTime.DataBind();
            DropDownListTime.DataTextField = "ServicePeriod";
            //DropDownListPestName.DataValueField = "ID";
            DropDownListTime.DataBind();
            //DropDownListTime.Items.Insert(0, "ServicePeriod");*/
            //************************************************************************
            //Connection String
            string connString = @"data source = DESKTOP-F8MV33J\SHEKHARSQL; integrated security = true; database = PestExterminator3rdProject";

            //Query
            string sql = @"SELECT PestName FROM pestinfo ";

            //Create Connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //Open Connection
                conn.Open();

                //Create Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create data reader
                SqlDataReader rdr = cmd.ExecuteReader();

                //Loop through result set
                
                while (rdr.Read())
                {
                    //Add to Dropdown list
                    ListItem listItem = new ListItem();

                    listItem.Text = rdr["PestName"].ToString();
                    listItem.Value = rdr["PestName"].ToString();

                    DropDownListPestName.Items.Add(listItem);
                }
                //close Reader
                
                
               /* DropDownListPestName.DataSource = rdr;
                
                DropDownListPestName.DataTextField = "PestName";
                DropDownListPestName.DataValueField = "PestName";
                DropDownListPestName.DataBind();*/
                rdr.Close();

            }
            catch (Exception ex)
            {
                LabelOrder.Text = ex.Message;
            }
            finally
            {
                conn.Close(); // SqlDataAdapter closes connection by itself; but can fail in case of errors
            }
            //***************************************************************************
            //string connString1 = @"data source = .\sqlexpress; integrated security = true; database = PestExterminator3rdProject";

            //Query
            string sql1 = @"SELECT ServicePeriod FROM servicetimeinfo ";

            //Create Connection
            SqlConnection conn1 = new SqlConnection(connString);

            try
            {
                //Open Connection
                conn.Open();

                //Create Command
                SqlCommand cmd1 = new SqlCommand(sql1, conn);

                //Create data reader
                SqlDataReader rdr = cmd1.ExecuteReader();

                //Loop through result set
               while (rdr.Read())
                {
                    //Add to Dropdown list
                    ListItem listItem1 = new ListItem();

                    listItem1.Text = rdr["ServicePeriod"].ToString();
                    listItem1.Value = rdr["ServicePeriod"].ToString();

                    DropDownListTime.Items.Add(listItem1);
                }
                //close Reader
                
               
                rdr.Close();

            }
            catch (Exception ex)
            {
                LabelOrder.Text = ex.Message;
            }
            finally
            {
                conn.Close(); // SqlDataAdapter closes connection by itself; but can fail in case of errors
            }


        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownListPestName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonOrder_Click(object sender, EventArgs e)
        {
            /* SqlConnection con = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = PestExterminator3rdProject");
              SqlCommand cmd = new SqlCommand(@"insert into requestinfo   values('" + DropDownListPestName.SelectedValue + "')", con);
              SqlDataAdapter Adpt = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();

              Adpt.Fill(dt);


              GridViewRequest.DataSource = dt;
              GridViewRequest.DataBind();
              //Label1.Text = "record found";
              //updateGrid();*/
            //********************************************'
            string connString = @"data source = DESKTOP-F8MV33J\SHEKHARSQL; integrated security = true; database = PestExterminator3rdProject";

            //Query
            // string sql = @"insert into requestinfo1 (PestName) values(DropDownListPestName.SelectedValue)";
            //string sql = "insert into requestinfo1(PestName)" + "values('"+DropDownListPestName.SelectedValue+"')";
            string sql = "insert into requestinfo1(PestName,ServicePeriod,Date)" + "values('" + DropDownListPestName.SelectedValue + "','" + DropDownListTime.SelectedValue + "','" + Calendar1.SelectedDate.ToString("yyyyMMdd") + "')";


            //Create Connection
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                //Open Connection
                conn.Open();
                // LabelPest.Text = DropDownListPestName.SelectedValue;

                //Create Command
                //SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.ExecuteNonQuery();


                //Create data reader
                // SqlDataReader rdr = cmd.ExecuteReader();


                /* while (rdr.Read())
                 {
                // DropDownListPestName.DataSource = rdr;
                
                DropDownListPestName.DataTextField = "PestName";
                DropDownListPestName.DataValueField = "PestName";
                DropDownListPestName.DataSource = rdr;
                DropDownListPestName.DataBind();

            }*/

                //close Reader

                //rdr.Close();
                updateGrid();




            }
            catch (Exception ex)
            {
                LabelOrder.Text = ex.Message;
            }
            finally
            {
                conn.Close(); // SqlDataAdapter closes connection by itself; but can fail in case of errors
            }

        }

        protected void ButtonTimeSlot_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = PestExterminator3rdProject");
            SqlCommand cmd1 = new SqlCommand("select ServicePeriod from servicetimeinfo where ServicePeriod = '" + DropDownListTime.SelectedValue + "'", con);
            SqlDataAdapter Adpt1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            Adpt1.Fill(dt1);
            
            GridViewRequest.DataSource = dt1;
            GridViewRequest.DataBind();
            updateGrid();*/
            /********************************************************/
            //string connString1 = @"data source = .\sqlexpress; integrated security = true; database = PestExterminator3rdProject";

            //Query
            //string sql1 = @"insert into requestinfo1 values('" + DropDownListTime.SelectedValue + "')";
            // string sql1 = @"insert into requestinfo1(ServicePeriod) values(DropDownListTime.SelectedValue)";
            //string sql1 = "insert into requestinfo1(ServicePeriod)" + "values('" + DropDownListTime.SelectedValue + "')";

            //Create Connection
            //SqlConnection conn1 = new SqlConnection(connString1);
            //SqlCommand cmd1 = new SqlCommand(sql1, conn1);
            //try
            //{
            //Open Connection
            // conn1.Open();

            //Create Command
            //SqlCommand cmd1 = new SqlCommand(sql1, conn1);
            // cmd1.ExecuteNonQuery();

            //Create data reader
            //SqlDataReader rdr = cmd1.ExecuteReader();
            /* while (rdr.Read())
             {

                 GridViewRequest.SelectedRow.Cells[1].Text = rdr["PestName"].ToString();

                 GridViewRequest.DataSource = rdr;
                 GridViewRequest.DataBind();

             }*/

            //close Reader

            //rdr.Close();
            // updateGrid();

            //}
            // catch (Exception ex)
            //  {
            //     LabelOrder.Text = ex.Message;
            //}
            // finally
            // {
            //    conn1.Close(); // SqlDataAdapter closes connection by itself; but can fail in case of errors
            //}

             }

            protected void GridViewRequest_SelectedIndexChanged(object sender, EventArgs e)
             {
             GridViewRequest.SelectedRow.Cells[1].Text = DropDownListPestName.SelectedValue;
            GridViewRequest.SelectedRow.Cells[2].Text = DropDownListTime.SelectedValue;
            GridViewRequest.SelectedRow.Cells[3].Text = Calendar1.SelectedDate.ToString("yyyyMMdd");


        }

        protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
        {

        }
    }
        } 