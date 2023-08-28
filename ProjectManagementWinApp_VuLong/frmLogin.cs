using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementWinApp_VuLong
{
    public partial class frmLogin : Form
    {
        private static readonly string ADMIN_ROLE = "Admin";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                // get the admin account from appsettings.json
                IConfiguration config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true).Build();
                var adEmail = config["AdminAccount:Email"];
                var adPassword = config["AdminAccount:Password"];
                var adRole = config["AdminAccount:Role"];
                if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Field required!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (adEmail.Equals(email) && adPassword.Equals(password))
                {
                    if (ADMIN_ROLE.Equals(adRole))
                    {
                        frmProjectMgmt frmProjectMgmt = new frmProjectMgmt();
                        frmProjectMgmt.Show();
                        this.Hide();
                        frmProjectMgmt.FormClosed += (s, args) => this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Role is not supported!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Email or Password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
