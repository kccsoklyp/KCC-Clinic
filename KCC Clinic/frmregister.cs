using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCC_Clinic
{
    public partial class frmregister : Form
    {
        public frmregister()
        {
            InitializeComponent();
        }

        private void txtLogIn_Click(object sender, EventArgs e)
        {
            new frmlogin().Show();
            this.Close();
        }

        internal class Show
        {
            public Show()
            {
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (signup_email.Text == "" || signup_Username.Text == "" || signup_Pass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 1. Connection string to the SQL server and database
            string connectionString = "Data Source=D7720_ID4SOKLYP;Initial Catalog=kccclinic;Persist Security Info=True;User ID=soklyp;Password=admin;TrustServerCertificate=True";
            //string connectionString = "Data Source=D7720_ID4Soklyp\\SQLEXPRESS;Initial Catalog=kccclinic;Persist Security Info=True;User ID=sa;Password=Admin;Encrypt=True;TrustServerCertificate=True";

            try
            {
                // 2. Establishing connection using the connection string
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // 3. Open connection
                    conn.Open();

                    // 4. Check if the username already exists in the database
                    string checkUsername = "SELECT * FROM admin WHERE username = @username";
                    using (SqlCommand checkUser = new SqlCommand(checkUsername, conn))
                    {
                        checkUser.Parameters.AddWithValue("@username", signup_Username.Text.Trim());

                        using (SqlDataAdapter adapter = new SqlDataAdapter(checkUser))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_Username.Text + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // 5. Insert new user into the database
                                string insertData = "INSERT INTO admin (email, username, password, date_created) VALUES (@email, @username, @pass, @date)";
                                using (SqlCommand cmd = new SqlCommand(insertData, conn))
                                {
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_Username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_Pass.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", DateTime.Now);

                                    cmd.ExecuteNonQuery();

                                    // 6. Show success message and redirect to login form
                                    MessageBox.Show("Registered successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Show Login form
                                    frmlogin frmLogin = new frmlogin();
                                    frmLogin.ShowDialog();
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle database connection errors
                MessageBox.Show("Error connecting to database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmregister_Load(object sender, EventArgs e)
        {
            PanelRegister.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPass.Checked)
            {
                // Show password
                signup_Pass.PasswordChar = '\0'; // '\0' removes the masking character
            }
            else
            {
                // Hide password
                signup_Pass.PasswordChar = '*'; // '*' sets the masking character
            }
        }

        private void signup_LoginHere_Click(object sender, EventArgs e)
        {
            frmlogin sForm = new frmlogin();
            sForm.ShowDialog();
            this.Close();
        }

        private void frmLogin_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
