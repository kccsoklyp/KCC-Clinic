namespace KCC_Clinic
{
    partial class frmregister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmregister));
            this.registerForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.signup_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.user_loginnavbar = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSignUpform = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAlready = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SeparatorRed = new Guna.UI2.WinForms.Guna2Separator();
            this.SeparatorGray = new Guna.UI2.WinForms.Guna2Separator();
            this.btnShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.signup_btn = new Guna.UI2.WinForms.Guna2Button();
            this.signup_Pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEnter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtwelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.signup_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelRegister = new Guna.UI2.WinForms.Guna2Panel();
            this.signup_LoginHere = new System.Windows.Forms.Label();
            this.frmLogin_Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.user_loginnavbar.SuspendLayout();
            this.PanelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerForm
            // 
            this.registerForm.BorderRadius = 20;
            this.registerForm.TargetControl = this;
            // 
            // signup_Username
            // 
            this.signup_Username.Animated = true;
            this.signup_Username.BorderRadius = 3;
            this.signup_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signup_Username.DefaultText = "";
            this.signup_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signup_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signup_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signup_Username.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signup_Username.IconLeft = ((System.Drawing.Image)(resources.GetObject("signup_Username.IconLeft")));
            this.signup_Username.Location = new System.Drawing.Point(16, 286);
            this.signup_Username.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.signup_Username.Name = "signup_Username";
            this.signup_Username.PasswordChar = '\0';
            this.signup_Username.PlaceholderText = "Username";
            this.signup_Username.SelectedText = "";
            this.signup_Username.Size = new System.Drawing.Size(300, 50);
            this.signup_Username.TabIndex = 1;
            // 
            // loginForm
            // 
            this.loginForm.BorderRadius = 20;
            // 
            // user_loginnavbar
            // 
            this.user_loginnavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.user_loginnavbar.Controls.Add(this.frmLogin_Close);
            this.user_loginnavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_loginnavbar.Location = new System.Drawing.Point(0, 0);
            this.user_loginnavbar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.user_loginnavbar.Name = "user_loginnavbar";
            this.user_loginnavbar.Size = new System.Drawing.Size(1280, 30);
            this.user_loginnavbar.TabIndex = 12;
            // 
            // txtSignUpform
            // 
            this.txtSignUpform.BackColor = System.Drawing.Color.Transparent;
            this.txtSignUpform.Font = new System.Drawing.Font("Khmer OS Siemreap", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUpform.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSignUpform.Location = new System.Drawing.Point(120, 40);
            this.txtSignUpform.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSignUpform.Name = "txtSignUpform";
            this.txtSignUpform.Size = new System.Drawing.Size(104, 51);
            this.txtSignUpform.TabIndex = 7;
            this.txtSignUpform.Text = "Sign Up";
            // 
            // txtAlready
            // 
            this.txtAlready.BackColor = System.Drawing.Color.Transparent;
            this.txtAlready.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlready.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAlready.Location = new System.Drawing.Point(20, 556);
            this.txtAlready.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAlready.Name = "txtAlready";
            this.txtAlready.Size = new System.Drawing.Size(194, 31);
            this.txtAlready.TabIndex = 10;
            this.txtAlready.Text = "Already have an account ?";
            // 
            // SeparatorRed
            // 
            this.SeparatorRed.BackColor = System.Drawing.Color.Transparent;
            this.SeparatorRed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.SeparatorRed.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SeparatorRed.FillThickness = 5;
            this.SeparatorRed.Location = new System.Drawing.Point(208, 586);
            this.SeparatorRed.Name = "SeparatorRed";
            this.SeparatorRed.Size = new System.Drawing.Size(100, 10);
            this.SeparatorRed.TabIndex = 21;
            this.SeparatorRed.UseTransparentBackground = true;
            // 
            // SeparatorGray
            // 
            this.SeparatorGray.BackColor = System.Drawing.Color.Transparent;
            this.SeparatorGray.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SeparatorGray.FillThickness = 5;
            this.SeparatorGray.Location = new System.Drawing.Point(18, 586);
            this.SeparatorGray.Name = "SeparatorGray";
            this.SeparatorGray.Size = new System.Drawing.Size(200, 10);
            this.SeparatorGray.TabIndex = 20;
            this.SeparatorGray.UseTransparentBackground = true;
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
            this.btnShowPass.Location = new System.Drawing.Point(177, 414);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(137, 31);
            this.btnShowPass.TabIndex = 4;
            this.btnShowPass.Text = "Show Password";
            this.btnShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnShowPass.UncheckedState.BorderRadius = 0;
            this.btnShowPass.UncheckedState.BorderThickness = 0;
            this.btnShowPass.UncheckedState.FillColor = System.Drawing.Color.White;
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.CheckedChanged += new System.EventHandler(this.btnShowPass_CheckedChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.Animated = true;
            this.signup_btn.BackColor = System.Drawing.Color.Transparent;
            this.signup_btn.BorderRadius = 3;
            this.signup_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signup_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signup_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signup_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signup_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.signup_btn.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.Location = new System.Drawing.Point(16, 459);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(300, 50);
            this.signup_btn.TabIndex = 5;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.UseTransparentBackground = true;
            this.signup_btn.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // signup_Pass
            // 
            this.signup_Pass.Animated = true;
            this.signup_Pass.BorderRadius = 3;
            this.signup_Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signup_Pass.DefaultText = "";
            this.signup_Pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signup_Pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signup_Pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_Pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_Pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signup_Pass.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_Pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signup_Pass.IconLeft = ((System.Drawing.Image)(resources.GetObject("signup_Pass.IconLeft")));
            this.signup_Pass.Location = new System.Drawing.Point(16, 350);
            this.signup_Pass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.signup_Pass.Name = "signup_Pass";
            this.signup_Pass.PasswordChar = '*';
            this.signup_Pass.PlaceholderText = "Password";
            this.signup_Pass.SelectedText = "";
            this.signup_Pass.Size = new System.Drawing.Size(300, 50);
            this.signup_Pass.TabIndex = 2;
            // 
            // txtEnter
            // 
            this.txtEnter.BackColor = System.Drawing.Color.Transparent;
            this.txtEnter.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEnter.Location = new System.Drawing.Point(79, 178);
            this.txtEnter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(193, 29);
            this.txtEnter.TabIndex = 9;
            this.txtEnter.Text = "Enter your credential sign up";
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
            this.txtwelcome.TabIndex = 8;
            this.txtwelcome.Text = "Welcome Back";
            // 
            // signup_email
            // 
            this.signup_email.Animated = true;
            this.signup_email.BorderRadius = 3;
            this.signup_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signup_email.DefaultText = "";
            this.signup_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signup_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signup_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signup_email.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F);
            this.signup_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signup_email.IconLeft = ((System.Drawing.Image)(resources.GetObject("signup_email.IconLeft")));
            this.signup_email.Location = new System.Drawing.Point(16, 222);
            this.signup_email.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.signup_email.Name = "signup_email";
            this.signup_email.PasswordChar = '\0';
            this.signup_email.PlaceholderText = "Email Address";
            this.signup_email.SelectedText = "";
            this.signup_email.Size = new System.Drawing.Size(300, 50);
            this.signup_email.TabIndex = 3;
            // 
            // PanelRegister
            // 
            this.PanelRegister.BackColor = System.Drawing.Color.White;
            this.PanelRegister.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.PanelRegister.BorderRadius = 10;
            this.PanelRegister.Controls.Add(this.signup_LoginHere);
            this.PanelRegister.Controls.Add(this.txtSignUpform);
            this.PanelRegister.Controls.Add(this.signup_Username);
            this.PanelRegister.Controls.Add(this.signup_email);
            this.PanelRegister.Controls.Add(this.txtwelcome);
            this.PanelRegister.Controls.Add(this.txtEnter);
            this.PanelRegister.Controls.Add(this.signup_Pass);
            this.PanelRegister.Controls.Add(this.signup_btn);
            this.PanelRegister.Controls.Add(this.txtAlready);
            this.PanelRegister.Controls.Add(this.btnShowPass);
            this.PanelRegister.Controls.Add(this.SeparatorRed);
            this.PanelRegister.Controls.Add(this.SeparatorGray);
            this.PanelRegister.CustomBorderColor = System.Drawing.Color.WhiteSmoke;
            this.PanelRegister.Location = new System.Drawing.Point(480, 100);
            this.PanelRegister.Name = "PanelRegister";
            this.PanelRegister.Size = new System.Drawing.Size(330, 620);
            this.PanelRegister.TabIndex = 25;
            // 
            // signup_LoginHere
            // 
            this.signup_LoginHere.AutoSize = true;
            this.signup_LoginHere.BackColor = System.Drawing.Color.Transparent;
            this.signup_LoginHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_LoginHere.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_LoginHere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.signup_LoginHere.Location = new System.Drawing.Point(220, 556);
            this.signup_LoginHere.Name = "signup_LoginHere";
            this.signup_LoginHere.Size = new System.Drawing.Size(92, 27);
            this.signup_LoginHere.TabIndex = 22;
            this.signup_LoginHere.Text = "Login here";
            this.signup_LoginHere.Click += new System.EventHandler(this.signup_LoginHere_Click);
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
            this.frmLogin_Close.TabIndex = 15;
            this.frmLogin_Close.Click += new System.EventHandler(this.frmLogin_Close_Click);
            // 
            // frmregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.PanelRegister);
            this.Controls.Add(this.user_loginnavbar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmregister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmregister";
            this.Load += new System.EventHandler(this.frmregister_Load);
            this.user_loginnavbar.ResumeLayout(false);
            this.PanelRegister.ResumeLayout(false);
            this.PanelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse registerForm;
        private Guna.UI2.WinForms.Guna2TextBox signup_Username;
        private Guna.UI2.WinForms.Guna2Panel user_loginnavbar;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtSignUpform;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtAlready;
        private Guna.UI2.WinForms.Guna2Separator SeparatorRed;
        private Guna.UI2.WinForms.Guna2Separator SeparatorGray;
        private Guna.UI2.WinForms.Guna2CheckBox btnShowPass;
        private Guna.UI2.WinForms.Guna2Button signup_btn;
        private Guna.UI2.WinForms.Guna2TextBox signup_Pass;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtEnter;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtwelcome;
        private Guna.UI2.WinForms.Guna2Elipse loginForm;
        private Guna.UI2.WinForms.Guna2TextBox signup_email;
        private Guna.UI2.WinForms.Guna2Panel PanelRegister;
        private System.Windows.Forms.Label signup_LoginHere;
        private Guna.UI2.WinForms.Guna2ControlBox frmLogin_Close;
    }
}