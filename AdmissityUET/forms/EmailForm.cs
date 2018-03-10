using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissityUET.forms
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Enter Email and Password");
                return;
            }
            try
            {
                MailAddress emaili = new MailAddress(txtEmail.Text);

            }
            catch
            {
                MessageBox.Show("Email Address is not valid");
                return;
            }
            string email = txtEmail.Text;
            string pass = txtPassword.Text;
            AdmissityUET.Properties.Settings.Default.UserEmail = email;
            AdmissityUET.Properties.Settings.Default.YourEmailPassword = pass;
            AdmissityUET.Properties.Settings.Default.Save();
            this.Hide();

        }
    }
}
