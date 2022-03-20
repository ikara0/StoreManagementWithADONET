using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Dtos;

namespace BilgeAdam.ADONET.LoginPage
{
    public partial class frmRegister : Form
    {
        private readonly IAuthenticationService service;
        public frmRegister(IAuthenticationService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            var result = service.GetSecurityQuestions();
            cmbSecurity.DataSource = result;
            cmbSecurity.DisplayMember = nameof(SecurityQuestionOptionDto.Question);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            errP1.Clear();
            if (!IsPasswordMatched(txtPassword.Text, txtPasswordAgain.Text))
            {
                errP1.SetError(txtPassword, "Parola uyuşmazlığı!");
                errP1.SetError(txtPasswordAgain, "Parola uyuşmazlığı!");
                return;
            }

            var selectedQuestion = cmbSecurity.SelectedItem as SecurityQuestionOptionDto;
            var dto = new NewUserDto
            {
                FirstName = txtfirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Password = txtPasswordAgain.Text,
                SecurityQuestionId = selectedQuestion.Id,
                Answer = txtAnswer.Text
            };

            var result = service.RegisterUser(dto);
            if (result)
            {
                MessageBox.Show("Kayıt Başarılı :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayıt Oluşturulamadı :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //helper
        private bool IsPasswordMatched(string password, string passwordAgain)
        {
            return password == passwordAgain;
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister_Click(null, null);
            }
        }
    }
}
