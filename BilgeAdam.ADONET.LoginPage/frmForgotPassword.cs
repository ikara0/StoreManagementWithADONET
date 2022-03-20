using BilgeAdam.ADONET.LoginPage.Extensions;
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
    public partial class frmForgotPassword : Form
    {
        private readonly IAuthenticationService service;
        private UserQuestionDto user;
        public frmForgotPassword(IAuthenticationService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            errP.Clear();
            var result = service.GetUserByEmail(txtEmail.Text);
            if (result == null)
            {
                errP.SetError(txtEmail, "Böyle bir mail bulunamadı!");
                return;
            }

            grbSecurityQuestionArea.Visible = true;
            lbl_Question.Text = result.Question;
            user = result;
        }

        private void btnSendAnswer_Click(object sender, EventArgs e)
        {
            if(user.Answer != txtAnswer.Text)
            {
                errP.SetError(txtAnswer, "Cevabınız doğru değildir!");
                return;
            }
            this.Switch(new frmRefreshPassword(service, user.Id));
        }
    }
}
