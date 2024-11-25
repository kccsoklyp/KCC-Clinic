using KCC_Clinic.Patients;
using System;
using System.Threading;
using System.Windows.Forms;

namespace KCC_Clinic
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void Guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (guna2ComboBox2.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("th-TH");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("km-KH");
                    break;
                case 2:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    break;
            }
            this.Controls.Clear();
            NewMethod();
        }

        private void NewMethod()
        {
            InitializeComponent();
        }

        private void guna2btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2btnmaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void guna2btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        bool sidebarExpand = true;
       
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                guna2PanelMenu.Width -= 5;
                if (guna2PanelMenu.Width <= 84)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else 
            {
                guna2PanelMenu.Width += 5;
                if (guna2PanelMenu.Width >= 210)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {          
            new frmlogin().Show();
            Close();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            new frmpatients().Show();
        }
    }
}