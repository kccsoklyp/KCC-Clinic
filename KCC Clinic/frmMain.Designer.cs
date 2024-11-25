namespace KCC_Clinic
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.frmBorder = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PanelNavbar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PicLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2btnmaximize = new Guna.UI2.WinForms.Guna2Button();
            this.guna2btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Languages = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Textsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2SeparatorNavbar = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnCompany = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnInvoices = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoctors = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatients = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2SeparatorMenu = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.guna2PanelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PicLogo)).BeginInit();
            this.guna2PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmBorder
            // 
            this.frmBorder.BorderRadius = 10;
            this.frmBorder.TargetControl = this;
            // 
            // guna2PanelNavbar
            // 
            resources.ApplyResources(this.guna2PanelNavbar, "guna2PanelNavbar");
            this.guna2PanelNavbar.Controls.Add(this.guna2btnMenu);
            this.guna2PanelNavbar.Controls.Add(this.guna2PicLogo);
            this.guna2PanelNavbar.Controls.Add(this.guna2btnClose);
            this.guna2PanelNavbar.Controls.Add(this.guna2btnmaximize);
            this.guna2PanelNavbar.Controls.Add(this.guna2btnMinimize);
            this.guna2PanelNavbar.Controls.Add(this.guna2ComboBox2);
            this.guna2PanelNavbar.Controls.Add(this.guna2Languages);
            this.guna2PanelNavbar.Controls.Add(this.guna2Textsearch);
            this.guna2PanelNavbar.Controls.Add(this.guna2SeparatorNavbar);
            this.guna2PanelNavbar.Name = "guna2PanelNavbar";
            // 
            // guna2btnMenu
            // 
            resources.ApplyResources(this.guna2btnMenu, "guna2btnMenu");
            this.guna2btnMenu.Animated = true;
            this.guna2btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.guna2btnMenu.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2btnMenu.BorderRadius = 3;
            this.guna2btnMenu.CustomImages.CheckedImage = global::KCC_Clinic.Properties.Resources.Menu_B;
            this.guna2btnMenu.CustomImages.HoveredImage = global::KCC_Clinic.Properties.Resources.Menu_B;
            this.guna2btnMenu.CustomImages.Image = global::KCC_Clinic.Properties.Resources.Menu_A;
            this.guna2btnMenu.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2btnMenu.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnMenu.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.guna2btnMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.guna2btnMenu.HoverState.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2btnMenu.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2btnMenu.Name = "guna2btnMenu";
            this.guna2btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2btnMenu.TextOffset = new System.Drawing.Point(40, 0);
            this.guna2btnMenu.UseTransparentBackground = true;
            this.guna2btnMenu.Click += new System.EventHandler(this.guna2btnMenu_Click);
            // 
            // guna2PicLogo
            // 
            resources.ApplyResources(this.guna2PicLogo, "guna2PicLogo");
            this.guna2PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.guna2PicLogo.BorderRadius = 5;
            this.guna2PicLogo.ImageRotate = 0F;
            this.guna2PicLogo.Name = "guna2PicLogo";
            this.guna2PicLogo.TabStop = false;
            // 
            // guna2btnClose
            // 
            resources.ApplyResources(this.guna2btnClose, "guna2btnClose");
            this.guna2btnClose.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2btnClose.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2btnClose.Name = "guna2btnClose";
            this.guna2btnClose.Click += new System.EventHandler(this.guna2btnClose_Click);
            // 
            // guna2btnmaximize
            // 
            resources.ApplyResources(this.guna2btnmaximize, "guna2btnmaximize");
            this.guna2btnmaximize.Animated = true;
            this.guna2btnmaximize.BackColor = System.Drawing.Color.Transparent;
            this.guna2btnmaximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnmaximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnmaximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnmaximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnmaximize.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2btnmaximize.ForeColor = System.Drawing.Color.White;
            this.guna2btnmaximize.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2btnmaximize.Image = ((System.Drawing.Image)(resources.GetObject("guna2btnmaximize.Image")));
            this.guna2btnmaximize.Name = "guna2btnmaximize";
            this.guna2btnmaximize.UseTransparentBackground = true;
            this.guna2btnmaximize.Click += new System.EventHandler(this.guna2btnmaximize_Click);
            // 
            // guna2btnMinimize
            // 
            resources.ApplyResources(this.guna2btnMinimize, "guna2btnMinimize");
            this.guna2btnMinimize.Animated = true;
            this.guna2btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.guna2btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnMinimize.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2btnMinimize.ForeColor = System.Drawing.Color.White;
            this.guna2btnMinimize.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("guna2btnMinimize.Image")));
            this.guna2btnMinimize.Name = "guna2btnMinimize";
            this.guna2btnMinimize.UseTransparentBackground = true;
            this.guna2btnMinimize.Click += new System.EventHandler(this.guna2btnMinimize_Click);
            // 
            // guna2ComboBox2
            // 
            resources.ApplyResources(this.guna2ComboBox2, "guna2ComboBox2");
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderRadius = 3;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.Items.AddRange(new object[] {
            resources.GetString("guna2ComboBox2.Items"),
            resources.GetString("guna2ComboBox2.Items1"),
            resources.GetString("guna2ComboBox2.Items2")});
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.SelectedIndexChanged += new System.EventHandler(this.Guna2ComboBox2_SelectedIndexChanged);
            // 
            // guna2Languages
            // 
            resources.ApplyResources(this.guna2Languages, "guna2Languages");
            this.guna2Languages.BackColor = System.Drawing.Color.Transparent;
            this.guna2Languages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.guna2Languages.Name = "guna2Languages";
            // 
            // guna2Textsearch
            // 
            resources.ApplyResources(this.guna2Textsearch, "guna2Textsearch");
            this.guna2Textsearch.Animated = true;
            this.guna2Textsearch.BorderRadius = 3;
            this.guna2Textsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Textsearch.DefaultText = "";
            this.guna2Textsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2Textsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2Textsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2Textsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2Textsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Textsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Textsearch.IconLeftSize = new System.Drawing.Size(25, 25);
            this.guna2Textsearch.IconRight = global::KCC_Clinic.Properties.Resources.Search_A;
            this.guna2Textsearch.Name = "guna2Textsearch";
            this.guna2Textsearch.PasswordChar = '\0';
            this.guna2Textsearch.PlaceholderText = "";
            this.guna2Textsearch.SelectedText = "";
            // 
            // guna2SeparatorNavbar
            // 
            resources.ApplyResources(this.guna2SeparatorNavbar, "guna2SeparatorNavbar");
            this.guna2SeparatorNavbar.Name = "guna2SeparatorNavbar";
            // 
            // guna2PanelMenu
            // 
            resources.ApplyResources(this.guna2PanelMenu, "guna2PanelMenu");
            this.guna2PanelMenu.BackColor = System.Drawing.Color.White;
            this.guna2PanelMenu.Controls.Add(this.btnSetting);
            this.guna2PanelMenu.Controls.Add(this.btnLogout);
            this.guna2PanelMenu.Controls.Add(this.btnCompany);
            this.guna2PanelMenu.Controls.Add(this.btnMedicine);
            this.guna2PanelMenu.Controls.Add(this.btnInvoices);
            this.guna2PanelMenu.Controls.Add(this.btnDoctors);
            this.guna2PanelMenu.Controls.Add(this.btnPatients);
            this.guna2PanelMenu.Controls.Add(this.btnDashboard);
            this.guna2PanelMenu.Controls.Add(this.guna2SeparatorMenu);
            this.guna2PanelMenu.Name = "guna2PanelMenu";
            // 
            // btnSetting
            // 
            resources.ApplyResources(this.btnSetting, "btnSetting");
            this.btnSetting.Animated = true;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetting.BorderRadius = 3;
            this.btnSetting.CustomImages.CheckedImage = global::KCC_Clinic.Properties.Resources.Setting_B;
            this.btnSetting.CustomImages.HoveredImage = global::KCC_Clinic.Properties.Resources.Setting_B;
            this.btnSetting.CustomImages.Image = global::KCC_Clinic.Properties.Resources.Setting_A;
            this.btnSetting.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetting.FillColor = System.Drawing.Color.White;
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSetting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.btnSetting.HoverState.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.TextOffset = new System.Drawing.Point(40, 0);
            this.btnSetting.UseTransparentBackground = true;
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.Animated = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.btnLogout.BorderRadius = 3;
            this.btnLogout.CustomImages.CheckedImage = global::KCC_Clinic.Properties.Resources.Logout_B;
            this.btnLogout.CustomImages.HoveredImage = global::KCC_Clinic.Properties.Resources.Logout_B;
            this.btnLogout.CustomImages.Image = global::KCC_Clinic.Properties.Resources.Logout_B;
            this.btnLogout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.btnLogout.HoverState.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.TextOffset = new System.Drawing.Point(40, 0);
            this.btnLogout.UseTransparentBackground = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCompany
            // 
            resources.ApplyResources(this.btnCompany, "btnCompany");
            this.btnCompany.Animated = true;
            this.btnCompany.BackColor = System.Drawing.Color.Transparent;
            this.btnCompany.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompany.BorderRadius = 3;
            this.btnCompany.CustomImages.CheckedImage = global::KCC_Clinic.Properties.Resources.Company_B;
            this.btnCompany.CustomImages.HoveredImage = global::KCC_Clinic.Properties.Resources.Company_B;
            this.btnCompany.CustomImages.Image = global::KCC_Clinic.Properties.Resources.Company_A;
            this.btnCompany.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCompany.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCompany.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompany.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompany.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompany.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompany.FillColor = System.Drawing.Color.White;
            this.btnCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnCompany.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.btnCompany.HoverState.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompany.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCompany.TextOffset = new System.Drawing.Point(40, 0);
            this.btnCompany.UseTransparentBackground = true;
            // 
            // btnMedicine
            // 
            resources.ApplyResources(this.btnMedicine, "btnMedicine");
            this.btnMedicine.Animated = true;
            this.btnMedicine.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicine.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedicine.BorderRadius = 3;
            this.btnMedicine.CustomImages.CheckedImage = global::KCC_Clinic.Properties.Resources.Medicine_B;
            this.btnMedicine.CustomImages.HoveredImage = global::KCC_Clinic.Properties.Resources.Medicine_B;
            this.btnMedicine.CustomImages.Image = global::KCC_Clinic.Properties.Resources.Medicine_A;
            this.btnMedicine.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedicine.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedicine.FillColor = System.Drawing.Color.White;
            this.btnMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnMedicine.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.btnMedicine.HoverState.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedicine.TextOffset = new System.Drawing.Point(40, 0);
            this.btnMedicine.UseTransparentBackground = true;
            // 
            // btnInvoices
            // 
            resources.ApplyResources(this.btnInvoices, "btnInvoices");
            this.btnInvoices.Animated = true;
            this.btnInvoices.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoices.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnInvoices.BorderRadius = 3;
            this.btnInvoices.CustomImages.CheckedImage = global::KCC_Clinic.Properties.Resources.Invoice_B;
            this.btnInvoices.CustomImages.HoveredImage = global::KCC_Clinic.Properties.Resources.Invoice_B;
            this.btnInvoices.CustomImages.Image = global::KCC_Clinic.Properties.Resources.Invoice_A;
            this.btnInvoices.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInvoices.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnInvoices.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInvoices.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInvoices.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInvoices.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInvoices.FillColor = System.Drawing.Color.White;
            this.btnInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnInvoices.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.btnInvoices.HoverState.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoices.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInvoices.TextOffset = new System.Drawing.Point(40, 0);
            this.btnInvoices.UseTransparentBackground = true;
            // 
            // btnDoctors
            // 
            resources.ApplyResources(this.btnDoctors, "btnDoctors");
            this.btnDoctors.Animated = true;
            this.btnDoctors.BackColor = System.Drawing.Color.Transparent;
            this.btnDoctors.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoctors.BorderRadius = 3;
            this.btnDoctors.CustomImages.CheckedImage = global::KCC_Clinic.Properties.Resources.Doctors_B;
            this.btnDoctors.CustomImages.HoveredImage = global::KCC_Clinic.Properties.Resources.Doctors_B;
            this.btnDoctors.CustomImages.Image = global::KCC_Clinic.Properties.Resources.Doctors_A;
            this.btnDoctors.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoctors.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDoctors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoctors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoctors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoctors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoctors.FillColor = System.Drawing.Color.White;
            this.btnDoctors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnDoctors.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.btnDoctors.HoverState.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoctors.TextOffset = new System.Drawing.Point(40, 0);
            this.btnDoctors.UseTransparentBackground = true;
            // 
            // btnPatients
            // 
            resources.ApplyResources(this.btnPatients, "btnPatients");
            this.btnPatients.Animated = true;
            this.btnPatients.BackColor = System.Drawing.Color.Transparent;
            this.btnPatients.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPatients.BorderRadius = 3;
            this.btnPatients.CustomImages.CheckedImage = global::KCC_Clinic.Properties.Resources.Patient_B;
            this.btnPatients.CustomImages.HoveredImage = global::KCC_Clinic.Properties.Resources.Patient_B;
            this.btnPatients.CustomImages.Image = global::KCC_Clinic.Properties.Resources.Patient_A;
            this.btnPatients.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatients.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPatients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatients.FillColor = System.Drawing.Color.White;
            this.btnPatients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnPatients.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.btnPatients.HoverState.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatients.TextOffset = new System.Drawing.Point(40, 0);
            this.btnPatients.UseTransparentBackground = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnDashboard
            // 
            resources.ApplyResources(this.btnDashboard, "btnDashboard");
            this.btnDashboard.Animated = true;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.BorderRadius = 3;
            this.btnDashboard.CustomImages.CheckedImage = global::KCC_Clinic.Properties.Resources.Dashboard_B;
            this.btnDashboard.CustomImages.HoveredImage = global::KCC_Clinic.Properties.Resources.Dashboard_B;
            this.btnDashboard.CustomImages.Image = global::KCC_Clinic.Properties.Resources.Dashboard_A;
            this.btnDashboard.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.White;
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(27)))));
            this.btnDashboard.HoverState.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(40, 0);
            this.btnDashboard.UseTransparentBackground = true;
            // 
            // guna2SeparatorMenu
            // 
            resources.ApplyResources(this.guna2SeparatorMenu, "guna2SeparatorMenu");
            this.guna2SeparatorMenu.Name = "guna2SeparatorMenu";
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2PanelNavbar);
            this.Controls.Add(this.guna2PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.guna2PanelNavbar.ResumeLayout(false);
            this.guna2PanelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PicLogo)).EndInit();
            this.guna2PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmBorder;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelMenu;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelNavbar;
        private Guna.UI2.WinForms.Guna2Separator guna2SeparatorNavbar;
        private Guna.UI2.WinForms.Guna2Separator guna2SeparatorMenu;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnCompany;
        private Guna.UI2.WinForms.Guna2Button btnMedicine;
        private Guna.UI2.WinForms.Guna2Button btnInvoices;
        private Guna.UI2.WinForms.Guna2Button btnDoctors;
        private Guna.UI2.WinForms.Guna2Button btnPatients;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private Guna.UI2.WinForms.Guna2Button guna2btnMenu;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PicLogo;
        private Guna.UI2.WinForms.Guna2TextBox guna2Textsearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2Languages;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button guna2btnMinimize;
        private Guna.UI2.WinForms.Guna2Button guna2btnmaximize;
        private Guna.UI2.WinForms.Guna2ControlBox guna2btnClose;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}

