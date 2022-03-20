namespace BilgeAdam.ADONET.LoginPage
{
    partial class frmForgotPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbSecurityQuestionArea = new System.Windows.Forms.GroupBox();
            this.btnSendAnswer = new System.Windows.Forms.Button();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbSecurityQuestionArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(48, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(254, 23);
            this.txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email Adresinizi Giriniz";
            // 
            // grbSecurityQuestionArea
            // 
            this.grbSecurityQuestionArea.Controls.Add(this.btnSendAnswer);
            this.grbSecurityQuestionArea.Controls.Add(this.lbl_Question);
            this.grbSecurityQuestionArea.Controls.Add(this.label3);
            this.grbSecurityQuestionArea.Controls.Add(this.label2);
            this.grbSecurityQuestionArea.Controls.Add(this.txtAnswer);
            this.grbSecurityQuestionArea.Location = new System.Drawing.Point(48, 167);
            this.grbSecurityQuestionArea.Name = "grbSecurityQuestionArea";
            this.grbSecurityQuestionArea.Size = new System.Drawing.Size(254, 196);
            this.grbSecurityQuestionArea.TabIndex = 2;
            this.grbSecurityQuestionArea.TabStop = false;
            this.grbSecurityQuestionArea.Visible = false;
            // 
            // btnSendAnswer
            // 
            this.btnSendAnswer.Location = new System.Drawing.Point(52, 153);
            this.btnSendAnswer.Name = "btnSendAnswer";
            this.btnSendAnswer.Size = new System.Drawing.Size(164, 27);
            this.btnSendAnswer.TabIndex = 2;
            this.btnSendAnswer.Text = "Gönder";
            this.btnSendAnswer.UseVisualStyleBackColor = true;
            this.btnSendAnswer.Click += new System.EventHandler(this.btnSendAnswer_Click);
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Question.Location = new System.Drawing.Point(6, 58);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(0, 15);
            this.lbl_Question.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cevap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Güvenlik Sorusu";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(6, 115);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PlaceholderText = "Answer";
            this.txtAnswer.Size = new System.Drawing.Size(210, 23);
            this.txtAnswer.TabIndex = 0;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(81, 114);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(164, 27);
            this.btnSendEmail.TabIndex = 2;
            this.btnSendEmail.Text = "Gönder";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 389);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.grbSecurityQuestionArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ParolamıUnuttum";
            this.grbSecurityQuestionArea.ResumeLayout(false);
            this.grbSecurityQuestionArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private GroupBox grbSecurityQuestionArea;
        private Button btnSendAnswer;
        private Label lbl_Question;
        private Label label3;
        private Label label2;
        private TextBox txtAnswer;
        private Button btnSendEmail;
        private ErrorProvider errP;
    }
}