using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.ADONET.LoginPage
{
    public partial class frmRefreshPassword : Form
    {
        private readonly IAuthenticationService service;
        private readonly int userId;
        public frmRefreshPassword(IAuthenticationService service, int userId)
        {
            InitializeComponent();
            this.service = service;
            this.userId = userId;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            errP.Clear();

            if(txtPassword.Text != txtPasswordAgain.Text)
            {
                errP.SetError(txtPassword, "Şifre Uyuşmazlığı!");
                errP.SetError(txtPasswordAgain, "Şifre Uyuşmazlığı!");
                return;
            }

            var dto = new UpdateUserPasswordDto() { Password = txtPassword.Text, UserId = userId };
            var result = service.UpdateUserPasswordDto(dto);
            if (result)
            {
                MessageBox.Show("İşlem Başarılı", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İşlem Başarısız", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
