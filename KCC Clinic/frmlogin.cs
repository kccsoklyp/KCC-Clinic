using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KCC_Clinic
{
    public partial class frmlogin : Form
    {

        public frmlogin()
        {
            InitializeComponent();
        }

        private void txtSignUp_Click_1(object sender, EventArgs e)
        {
            frmregister sForm = new frmregister();
            sForm.ShowDialog();  // Display Register Form as a dialog
            Close();        // Close the Login Form after opening Register Form
        }

        private void btnShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPass.Checked)
            {
                // Show password
                login_Password.PasswordChar = '\0'; // '\0' removes the masking character
            }
            else
            {
                // Hide password
                login_Password.PasswordChar = '*'; // '*' sets the masking character
            }
        }
        private void frmlogin_Load(object sender, EventArgs e)
        {
            PanelLogin.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_Username.Text) || string.IsNullOrWhiteSpace(login_Password.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1. Connection string to the SQL server and database (preferably moved to config files for security)
            string connectionString = "Data Source=D7720_ID4SOKLYP;Initial Catalog=kccclinic;Persist Security Info=True;User ID=soklyp;Password=admin;TrustServerCertificate=True";
            //string connectionString = "Data Source=192.168.203.50,1433;Initial Catalog=kccclinic;Persist Security Info=True;User ID=sa;Password=Admin;Encrypt=False;TrustServerCertificate=True";

            try
            {
                // 2. Establishing connection using the connection string
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // 3. Open connection
                    conn.Open();

                    // 4. Check if the username and password match in the database
                    string checkUsernameQuery = "SELECT * FROM admin WHERE username = @username AND password = @pass";
                    using (SqlCommand checkUser = new SqlCommand(checkUsernameQuery, conn))
                    {
                        checkUser.Parameters.AddWithValue("@username", login_Username.Text.Trim());
                        checkUser.Parameters.AddWithValue("@pass", login_Password.Text.Trim());

                        using (SqlDataAdapter adapter = new SqlDataAdapter(checkUser))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            // 5. Check if user exists
                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Optionally, open the main application form after login
                                frmMain mainForm = new frmMain();
                                mainForm.ShowDialog();
                                Application.Exit();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle database connection errors
                MessageBox.Show("Error connecting: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void txtSignUp_Click(object sender, EventArgs e)
        {
            new frmregister.Show();
            Application.Exit();
        }

        private void frmLogin_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
   }

