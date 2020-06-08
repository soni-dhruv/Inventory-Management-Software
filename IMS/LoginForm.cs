using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(LLPasswordShow.Text == "Show")
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupForm sf = new SignupForm();
            sf.Show();
            this.Hide();
        }
    }
}
