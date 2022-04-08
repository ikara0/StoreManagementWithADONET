using BilgeAdam.ADONET.LoginPage.Extensions;
using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Dtos;

namespace BilgeAdam.ADONET.LoginPage
{
    public partial class frmForgotPassword : Form
    {
        private readonly IAuthenticationService service;
        private UserQuestionDto user;
        private int count = 1;
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

            if (user.Answer != txtAnswer.Text)
            {
                if (count == 3)
                {
                    service.BlokeTheUser(user);
                    MessageBox.Show("Hesabınız Bloke Olmuştur.Admine Başvurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Switch(new frmMain());
                }
                errP.SetError(txtAnswer, "Cevabınız doğru değildir!");
                count++;
                return;
            }
            this.Switch(new frmRefreshPassword(service, user.Id));
        }
    }
}
