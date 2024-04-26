
namespace QuizTimDersch
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.BoxPassword = new System.Windows.Forms.TextBox();
            this.BoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.textPasswordRegister = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsernameRegister = new System.Windows.Forms.TextBox();
            this.labelPWnotMatch = new System.Windows.Forms.Label();
            this.labelFillOutAllFields = new System.Windows.Forms.Label();
            this.labelUsernameExists = new System.Windows.Forms.Label();
            this.labelWrongPassword = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 25F);
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLogin.Location = new System.Drawing.Point(126, 12);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(132, 51);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "LOGIN";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPassword.Location = new System.Drawing.Point(36, 129);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 21);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUsername.Location = new System.Drawing.Point(36, 90);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(84, 26);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username:";
            this.labelUsername.UseCompatibleTextRendering = true;
            // 
            // BoxPassword
            // 
            this.BoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxPassword.Font = new System.Drawing.Font("Calibri", 9F);
            this.BoxPassword.Location = new System.Drawing.Point(124, 124);
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.Size = new System.Drawing.Size(200, 26);
            this.BoxPassword.TabIndex = 1;
            this.BoxPassword.UseSystemPasswordChar = true;
            // 
            // BoxUsername
            // 
            this.BoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxUsername.Font = new System.Drawing.Font("Calibri", 9F);
            this.BoxUsername.Location = new System.Drawing.Point(124, 90);
            this.BoxUsername.Name = "BoxUsername";
            this.BoxUsername.Size = new System.Drawing.Size(200, 26);
            this.BoxUsername.TabIndex = 0;
            this.BoxUsername.TextChanged += new System.EventHandler(this.BoxUsername_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Calibri", 10F);
            this.buttonLogin.Location = new System.Drawing.Point(113, 228);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(158, 35);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Calibri", 10F);
            this.buttonRegister.Location = new System.Drawing.Point(113, 187);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(158, 35);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(121, 155);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(92, 13);
            this.linkLabelForgotPassword.TabIndex = 6;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Forgot Password?";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.labelWrongPassword);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Controls.Add(this.linkLabelForgotPassword);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.buttonRegister);
            this.panelLogin.Controls.Add(this.BoxPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Controls.Add(this.BoxUsername);
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(377, 285);
            this.panelLogin.TabIndex = 7;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint_1);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Font = new System.Drawing.Font("Calibri", 10F);
            this.buttonClose.Location = new System.Drawing.Point(821, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(26, 27);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "X";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // buttonHide
            // 
            this.buttonHide.BackColor = System.Drawing.Color.Transparent;
            this.buttonHide.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonHide.Location = new System.Drawing.Point(789, 12);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(26, 27);
            this.buttonHide.TabIndex = 9;
            this.buttonHide.Text = "-";
            this.buttonHide.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHide.UseVisualStyleBackColor = false;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.White;
            this.panelRegister.Controls.Add(this.panelLogin);
            this.panelRegister.Controls.Add(this.labelUsernameExists);
            this.panelRegister.Controls.Add(this.labelFillOutAllFields);
            this.panelRegister.Controls.Add(this.labelPWnotMatch);
            this.panelRegister.Controls.Add(this.label1);
            this.panelRegister.Controls.Add(this.textBoxRepeatPassword);
            this.panelRegister.Controls.Add(this.labelRegister);
            this.panelRegister.Controls.Add(this.label2);
            this.panelRegister.Controls.Add(this.buttonAddUser);
            this.panelRegister.Controls.Add(this.textPasswordRegister);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.textBoxUsernameRegister);
            this.panelRegister.Location = new System.Drawing.Point(248, 138);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(377, 285);
            this.panelRegister.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F);
            this.label1.Location = new System.Drawing.Point(6, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Repeat Password:";
            // 
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRepeatPassword.Font = new System.Drawing.Font("Calibri", 9F);
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(146, 156);
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(200, 26);
            this.textBoxRepeatPassword.TabIndex = 6;
            this.textBoxRepeatPassword.UseSystemPasswordChar = true;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.BackColor = System.Drawing.Color.Transparent;
            this.labelRegister.Font = new System.Drawing.Font("Calibri", 25F);
            this.labelRegister.Location = new System.Drawing.Point(94, 13);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(187, 51);
            this.labelRegister.TabIndex = 4;
            this.labelRegister.Text = "REGISTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F);
            this.label2.Location = new System.Drawing.Point(58, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Calibri", 10F);
            this.buttonAddUser.Location = new System.Drawing.Point(113, 218);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(158, 35);
            this.buttonAddUser.TabIndex = 5;
            this.buttonAddUser.Text = "Register";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // textPasswordRegister
            // 
            this.textPasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPasswordRegister.Font = new System.Drawing.Font("Calibri", 9F);
            this.textPasswordRegister.Location = new System.Drawing.Point(146, 124);
            this.textPasswordRegister.Name = "textPasswordRegister";
            this.textPasswordRegister.Size = new System.Drawing.Size(200, 26);
            this.textPasswordRegister.TabIndex = 1;
            this.textPasswordRegister.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F);
            this.label3.Location = new System.Drawing.Point(54, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // textBoxUsernameRegister
            // 
            this.textBoxUsernameRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsernameRegister.Font = new System.Drawing.Font("Calibri", 9F);
            this.textBoxUsernameRegister.Location = new System.Drawing.Point(146, 92);
            this.textBoxUsernameRegister.Name = "textBoxUsernameRegister";
            this.textBoxUsernameRegister.Size = new System.Drawing.Size(200, 26);
            this.textBoxUsernameRegister.TabIndex = 0;
            // 
            // labelPWnotMatch
            // 
            this.labelPWnotMatch.AutoSize = true;
            this.labelPWnotMatch.BackColor = System.Drawing.Color.Transparent;
            this.labelPWnotMatch.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelPWnotMatch.ForeColor = System.Drawing.Color.Red;
            this.labelPWnotMatch.Location = new System.Drawing.Point(89, 194);
            this.labelPWnotMatch.Name = "labelPWnotMatch";
            this.labelPWnotMatch.Size = new System.Drawing.Size(214, 21);
            this.labelPWnotMatch.TabIndex = 8;
            this.labelPWnotMatch.Text = "Your Passwords don\'t match!";
            // 
            // labelFillOutAllFields
            // 
            this.labelFillOutAllFields.AutoSize = true;
            this.labelFillOutAllFields.BackColor = System.Drawing.Color.Transparent;
            this.labelFillOutAllFields.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelFillOutAllFields.ForeColor = System.Drawing.Color.Red;
            this.labelFillOutAllFields.Location = new System.Drawing.Point(99, 194);
            this.labelFillOutAllFields.Name = "labelFillOutAllFields";
            this.labelFillOutAllFields.Size = new System.Drawing.Size(191, 21);
            this.labelFillOutAllFields.TabIndex = 10;
            this.labelFillOutAllFields.Text = "Fill out all required Fields!";
            // 
            // labelUsernameExists
            // 
            this.labelUsernameExists.AutoSize = true;
            this.labelUsernameExists.BackColor = System.Drawing.Color.Transparent;
            this.labelUsernameExists.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelUsernameExists.ForeColor = System.Drawing.Color.Red;
            this.labelUsernameExists.Location = new System.Drawing.Point(86, 194);
            this.labelUsernameExists.Name = "labelUsernameExists";
            this.labelUsernameExists.Size = new System.Drawing.Size(217, 21);
            this.labelUsernameExists.TabIndex = 11;
            this.labelUsernameExists.Text = "This Username already exists!";
            // 
            // labelWrongPassword
            // 
            this.labelWrongPassword.AutoSize = true;
            this.labelWrongPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelWrongPassword.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelWrongPassword.ForeColor = System.Drawing.Color.Red;
            this.labelWrongPassword.Location = new System.Drawing.Point(75, 64);
            this.labelWrongPassword.Name = "labelWrongPassword";
            this.labelWrongPassword.Size = new System.Drawing.Size(228, 21);
            this.labelWrongPassword.TabIndex = 12;
            this.labelWrongPassword.Text = "Wrong Password or Username!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(859, 560);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox BoxPassword;
        private System.Windows.Forms.TextBox BoxUsername;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.TextBox textPasswordRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsernameRegister;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsernameExists;
        private System.Windows.Forms.Label labelFillOutAllFields;
        private System.Windows.Forms.Label labelPWnotMatch;
        private System.Windows.Forms.Label labelWrongPassword;
    }
}

