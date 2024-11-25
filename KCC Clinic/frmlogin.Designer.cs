namespace KCC_Clinic
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.loginForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.user_loginnavbar = new Guna.UI2.WinForms.Guna2Panel();
            this.frmLogin_Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtwelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEnter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.login_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Login_btn = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SeparatorGray = new Guna.UI2.WinForms.Guna2Separator();
            this.SeparatorRed = new Guna.UI2.WinForms.Guna2Separator();
            this.txtDontHave = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PanelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.Forgot_Password = new System.Windows.Forms.Label();
            this.login_RegisterHere = new System.Windows.Forms.Label();
            this.user_loginnavbar.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginForm
            // 
            this.loginForm.BorderRadius = 10;
            this.loginForm.TargetControl = this;
            // 
            // user_loginnavbar
            // 
            this.user_loginnavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.user_loginnavbar.BorderRadius = 5;
            this.user_loginnavbar.Controls.Add(this.frmLogin_Close);
            this.user_loginnavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_loginnavbar.Location = new System.Drawing.Point(0, 0);
            this.user_loginnavbar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.user_loginnavbar.Name = "user_loginnavbar";
            this.user_loginnavbar.Size = new System.Drawing.Size(1280, 30);
            this.user_loginnavbar.TabIndex = 0;
            // 
            // frmLogin_Close
            // 
            this.frmLogin_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frmLogin_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmLogin_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.frmLogin_Close.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.frmLogin_Close.IconColor = System.Drawing.Color.White;
            this.frmLogin_Close.Location = new System.Drawing.Point(1235, 0);
            this.frmLogin_Close.Name = "frmLogin_Close";
            this.frmLogin_Close.Size = new System.Drawing.Size(45, 30);
            this.frmLogin_Close.TabIndex = 14;
            this.frmLogin_Close.Click += new System.EventHandler(this.frmLogin_Close_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtLogin.Font = new System.Drawing.Font("Khmer OS Siemreap", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogin.Location = new System.Drawing.Point(120, 40);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(92, 51);
            this.txtLogin.TabIndex = 8;
            this.txtLogin.Text = "LOG IN";
            // 
            // txtwelcome
            // 
            this.txtwelcome.BackColor = System.Drawing.Color.Transparent;
            this.txtwelcome.Font = new System.Drawing.Font("Khmer OS Siemreap", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwelcome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtwelcome.Location = new System.Drawing.Point(63, 109);
            this.txtwelcome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtwelcome.Name = "txtwelcome";
            this.txtwelcome.Size = new System.Drawing.Size(207, 54);
            this.txtwelcome.TabIndex = 9;
            this.txtwelcome.Text = "Welcome Back";
            // 
            // txtEnter
            // 
            this.txtEnter.BackColor = System.Drawing.Color.Transparent;
            this.txtEnter.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEnter.Location = new System.Drawing.Point(79, 178);
            this.txtEnter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(175, 29);
            this.txtEnter.TabIndex = 10;
            this.txtEnter.Text = "Enter your credential login";
            // 
            // login_Username
            // 
            this.login_Username.Animated = true;
            this.login_Username.BorderRadius = 3;
            this.login_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_Username.DefaultText = "";
            this.login_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_Username.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_Username.IconLeft = ((System.Drawing.Image)(resources.GetObject("login_Username.IconLeft")));
            this.login_Username.Location = new System.Drawing.Point(16, 222);
            this.login_Username.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.login_Username.Name = "login_Username";
            this.login_Username.PasswordChar = '\0';
            this.login_Username.PlaceholderText = "Username";
            this.login_Username.SelectedText = "";
            this.login_Username.Size = new System.Drawing.Size(300, 50);
            this.login_Username.TabIndex = 1;
            // 
            // login_Password
            // 
            this.login_Password.Animated = true;
            this.login_Password.BorderRadius = 3;
            this.login_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_Password.DefaultText = "";
            this.login_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_Password.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_Password.IconLeft = ((System.Drawing.Image)(resources.GetObject("login_Password.IconLeft")));
            this.login_Password.Location = new System.Drawing.Point(16, 287);
            this.login_Password.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.login_Password.Name = "login_Password";
            this.login_Password.PasswordChar = '*';
            this.login_Password.PlaceholderText = "Password";
            this.login_Password.SelectedText = "";
            this.login_Password.Size = new System.Drawing.Size(300, 50);
            this.login_Password.TabIndex = 2;
            // 
            // Login_btn
            // 
            this.Login_btn.Animated = true;
            this.Login_btn.BackColor = System.Drawing.Color.Transparent;
            this.Login_btn.BorderRadius = 3;
            this.Login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.Login_btn.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(14, 398);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(300, 50);
            this.Login_btn.TabIndex = 4;
            this.Login_btn.Text = "Log in";
            this.Login_btn.UseTransparentBackground = true;
            this.Login_btn.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.AutoSize = true;
            this.btnShowPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnShowPass.CheckedState.BorderRadius = 0;
            this.btnShowPass.CheckedState.BorderThickness = 0;
            this.btnShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPass.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F);
            this.btnShowPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowPass.Location = new System.Drawing.Point(186, 352);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(137, 31);
            this.btnShowPass.TabIndex = 3;
            this.btnShowPass.Text = "Show Password";
            this.btnShowPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnShowPass.UncheckedState.BorderRadius = 0;
            this.btnShowPass.UncheckedState.BorderThickness = 1;
            this.btnShowPass.UncheckedState.FillColor = System.Drawing.Color.White;
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.CheckedChanged += new System.EventHandler(this.btnShowPass_CheckedChanged);
            // 
            // SeparatorGray
            // 
            this.SeparatorGray.BackColor = System.Drawing.Color.Transparent;
            this.SeparatorGray.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SeparatorGray.FillThickness = 5;
            this.SeparatorGray.Location = new System.Drawing.Point(18, 586);
            this.SeparatorGray.Name = "SeparatorGray";
            this.SeparatorGray.Size = new System.Drawing.Size(200, 10);
            this.SeparatorGray.TabIndex = 8;
            this.SeparatorGray.UseTransparentBackground = true;
            // 
            // SeparatorRed
            // 
            this.SeparatorRed.BackColor = System.Drawing.Color.Transparent;
            this.SeparatorRed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.SeparatorRed.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SeparatorRed.FillThickness = 5;
            this.SeparatorRed.Location = new System.Drawing.Point(208, 586);
            this.SeparatorRed.Name = "SeparatorRed";
            this.SeparatorRed.Size = new System.Drawing.Size(110, 10);
            this.SeparatorRed.TabIndex = 9;
            this.SeparatorRed.UseTransparentBackground = true;
            // 
            // txtDontHave
            // 
            this.txtDontHave.BackColor = System.Drawing.Color.Transparent;
            this.txtDontHave.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDontHave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDontHave.Location = new System.Drawing.Point(18, 556);
            this.txtDontHave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDontHave.Name = "txtDontHave";
            this.txtDontHave.Size = new System.Drawing.Size(175, 31);
            this.txtDontHave.TabIndex = 7;
            this.txtDontHave.Text = "Don\'t have an account ?";
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.White;
            this.PanelLogin.BorderRadius = 10;
            this.PanelLogin.Controls.Add(this.Forgot_Password);
            this.PanelLogin.Controls.Add(this.login_RegisterHere);
            this.PanelLogin.Controls.Add(this.Login_btn);
            this.PanelLogin.Controls.Add(this.txtLogin);
            this.PanelLogin.Controls.Add(this.txtwelcome);
            this.PanelLogin.Controls.Add(this.txtDontHave);
            this.PanelLogin.Controls.Add(this.txtEnter);
            this.PanelLogin.Controls.Add(this.SeparatorRed);
            this.PanelLogin.Controls.Add(this.login_Username);
            this.PanelLogin.Controls.Add(this.SeparatorGray);
            this.PanelLogin.Controls.Add(this.login_Password);
            this.PanelLogin.Controls.Add(this.btnShowPass);
            this.PanelLogin.CustomBorderColor = System.Drawing.Color.WhiteSmoke;
            this.PanelLogin.Location = new System.Drawing.Point(480, 100);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(330, 620);
            this.PanelLogin.TabIndex = 12;
            // 
            // Forgot_Password
            // 
            this.Forgot_Password.AutoSize = true;
            this.Forgot_Password.BackColor = System.Drawing.Color.Transparent;
            this.Forgot_Password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Forgot_Password.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forgot_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.Forgot_Password.Location = new System.Drawing.Point(97, 485);
            this.Forgot_Password.Name = "Forgot_Password";
            this.Forgot_Password.Size = new System.Drawing.Size(139, 27);
            this.Forgot_Password.TabIndex = 5;
            this.Forgot_Password.Text = "Forgot Password ?";
            // 
            // login_RegisterHere
            // 
            this.login_RegisterHere.AutoSize = true;
            this.login_RegisterHere.BackColor = System.Drawing.Color.Transparent;
            this.login_RegisterHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_RegisterHere.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_RegisterHere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.login_RegisterHere.Location = new System.Drawing.Point(210, 556);
            this.login_RegisterHere.Name = "login_RegisterHere";
            this.login_RegisterHere.Size = new System.Drawing.Size(112, 27);
            this.login_RegisterHere.TabIndex = 6;
            this.login_RegisterHere.Text = "Register here";
            this.login_RegisterHere.Click += new System.EventHandler(this.txtSignUp_Click_1);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.user_loginnavbar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.user_loginnavbar.ResumeLayout(false);
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse loginForm;
        private Guna.UI2.WinForms.Guna2Panel user_loginnavbar;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtEnter;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtwelcome;
        private Guna.UI2.WinForms.Guna2Button Login_btn;
        private Guna.UI2.WinForms.Guna2TextBox login_Password;
        private Guna.UI2.WinForms.Guna2TextBox login_Username;
        private Guna.UI2.WinForms.Guna2CheckBox btnShowPass;
        private Guna.UI2.WinForms.Guna2Separator SeparatorGray;
        private Guna.UI2.WinForms.Guna2Separator SeparatorRed;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtDontHave;
        private Guna.UI2.WinForms.Guna2Panel PanelLogin;
        private Guna.UI2.WinForms.Guna2ControlBox frmLogin_Close;
        private System.Windows.Forms.Label login_RegisterHere;
        private System.Windows.Forms.Label Forgot_Password;
    }
}