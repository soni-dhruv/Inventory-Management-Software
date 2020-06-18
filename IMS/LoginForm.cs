using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBoxuID;
        }

        //X close button
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Hide Show Password
        private void LLPasswordShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LLPasswordShow.Text == "Show")
            {
                txtBoxPassword.PasswordChar = '\0';
                LLPasswordShow.Text = "Hide";
            }
            else
            {
                txtBoxPassword.PasswordChar = '●';
                LLPasswordShow.Text = "Show";
            }
        }

        //Enter Key Event
        private void txtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        // To Signup Page
        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupForm sf = new SignupForm();
            sf.Show();
            this.Hide();
        }

        // Login Button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // User ID Blank Validation
            if (txtBoxuID.Text == "")
            {
                errorProvider1.SetError(uName, "*Required Field");
            }
            else
            {
                errorProvider1.Clear();
            }

            // User ID Blank Validation
            if (txtBoxPassword.Text == "")
            {
                errorProvider2.SetError(uPassword, "*Required Field");
            }
            else
            {
                errorProvider2.Clear();
            }

            //Connection Database            
            SqlConnection con = new SqlConnection(@"Data Source=DHRUV;Initial Catalog=IMS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from signup where userId=@id and uPassword=@pass", con);
            cmd.Parameters.AddWithValue("@id", txtBoxuID.Text);
            cmd.Parameters.AddWithValue("@pass", txtBoxPassword.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Login Successful!");
                HomePage hp = new HomePage();
                hp.Show();
                this.Hide(); 
            }
            else
            {
                errorProvider3.SetError(btnLogin, "Kindly Enter Correct Username and Password");
            }            
        }
    }
}
