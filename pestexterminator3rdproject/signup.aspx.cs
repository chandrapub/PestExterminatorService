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
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSignup_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-F8MV33J\SHEKHARSQL; integrated security = true; database = PestExterminator3rdProject");
            SqlCommand cmd = null;

            try
            {
                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MyInsertioncustomerinfo";
                //cmd.CommandText = "MyInsertionZip";
                //cmd.CommandText = "MyInsertionPhone";

                SqlParameter in1 = cmd.Parameters.Add("@FirstName", SqlDbType.Text);
                in1.Direction = ParameterDirection.Input;
                in1.Value = TextBoxCustomerFirstName.Text;
                TextBoxCustomerFirstName.Text = "";

               SqlParameter in2 = cmd.Parameters.Add("@lastName", SqlDbType.Text);
                in2.Direction = ParameterDirection.Input;
                in2.Value = TextBoxCustomerLastName.Text;
                TextBoxCustomerLastName.Text = " ";

                SqlParameter in3 = cmd.Parameters.Add("@Street", SqlDbType.Text);
                in3.Direction = ParameterDirection.Input;
                in3.Value = TextBoxStreet.Text;
                TextBoxStreet.Text = " ";

                SqlParameter in4 = cmd.Parameters.Add("@HouseNo", SqlDbType.Text);
                in4.Direction = ParameterDirection.Input;
                in4.Value = TextBoxHouseNo.Text;
                TextBoxHouseNo.Text = " ";

                SqlParameter in5 = cmd.Parameters.Add("@ZipCode", SqlDbType.Int);
                in5.Direction = ParameterDirection.Input;
                in5.Value = Convert.ToInt32(TextBoxZipCode.Text);
                TextBoxZipCode.Text = " ";

                //SqlParameter in6 = cmd.Parameters.Add("@City", SqlDbType.Text);
                //in6.Direction = ParameterDirection.Input;
                //in6.Value = TextBoxCity.Text;

                SqlParameter in7 = cmd.Parameters.Add("@Mobile", SqlDbType.Text);
                in7.Direction = ParameterDirection.Input;
                in7.Value = TextBoxMobile.Text;
                TextBoxMobile.Text = " ";

                SqlParameter in8 = cmd.Parameters.Add("@HomePhone", SqlDbType.Text);
                in8.Direction = ParameterDirection.Input;
                in8.Value = TextBoxHomePhone.Text;
                TextBoxHomePhone.Text = " ";

                SqlParameter in9 = cmd.Parameters.Add("@Email", SqlDbType.Text);
                in9.Direction = ParameterDirection.Input;
                in9.Value = TextBoxEmail.Text;
                TextBoxEmail.Text = " ";

                SqlParameter in10 = cmd.Parameters.Add("@Password", SqlDbType.Text);
                in10.Direction = ParameterDirection.Input;
                in10.Value = TextBoxPassword.Text;
                TextBoxPassword.Text = " ";

                SqlParameter in11 = cmd.Parameters.Add("@ConfirmPassword", SqlDbType.Text);
                in11.Direction = ParameterDirection.Input;
                in11.Value = TextBoxConfirmPassword.Text;
                TextBoxConfirmPassword.Text = " ";


                cmd.ExecuteNonQuery();

                //ShowMyCats();
            }
            catch (Exception ex)
            {
                //LabelInfo.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void TextBoxCustomerFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxZipCode_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxMobile_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxHouseNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
