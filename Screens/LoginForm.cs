using ITSolutionSoftware.General;
using ITSolutionSoftware.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSolutionSoftware
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                using(SqlConnection con=new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Login_VerifiyLoginDetails",con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text.Trim());
                        con.Open(); 
                        SqlDataReader sdr=cmd.ExecuteReader();  
                        if(sdr.Read())
                        {
                            this.Hide();
                            DashboardForm df= new DashboardForm();
                            df.Show();  

                        }
                        else
                        {
                            MessageBox.Show("User Name or PAssword is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }
        private bool IsValid()
        {
            if(UserNameTextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("User Name is required!", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required!", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
