using POS_System_By_Akila_Udara.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_System_By_Akila_Udara.Screens;

namespace POS_System_By_Akila_Udara
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(isValid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Login_VerifyLoginDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text.Trim());

                        con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();
                        if(sdr.Read())
                        {
                            this.Hide();
                            DashBoardForm df = new DashBoardForm();
                            df.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password is incorrect ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private bool isValid()
        {
            if(UserNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User Name Required", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTextBox.Focus();
                return false;
            }

            if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password Required", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Focus();
                return false;
            }

            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
