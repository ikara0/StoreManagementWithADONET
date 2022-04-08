using BilgeAdam.ADONET.LoginPage.Extensions;
using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Concretes;
using BilgeAdam.Data.Dtos;
using System.ComponentModel;
using System.Data.SqlClient;

namespace BilgeAdam.ADONET.LoginPage
{
    public partial class frmMain : Form
    {
        private IAuthenticationService service;
        public frmMain()
        {
            InitializeComponent();
            service = new AuthenticationService();
        }
        private void btnEntry_Click(object sender, EventArgs e)
        {
            var dto = new CheckUserDto { Email = txtEmail.Text, Password = txtPassWord.Text};  
            var result = service.CheckUser(dto);
            if (result.IsActive)
            {
                MessageBox.Show("Giriş Başarılı :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Switch(new frmProductManagement());
                this.Show();
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEmail.Text = String.Empty;
                this.txtPassWord.Text = String.Empty; 
            }
        }

        private void btnEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnEntry_Click(null, null);
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnEntry_Click(null, null);
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Switch(new frmRegister(service));
            this.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Switch(new frmForgotPassword(service));
            this.Show();
        }
    }
}