using Hardware_shop.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hardware_shop
{
    public partial class frmLogin : Form
    {
        

        public frmLogin()
        {
            InitializeComponent();
        }

        private void picMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picMinimize, "Minimize");
        }

        private void PIcClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(PIcClose, "Close");
        }

        private void PIcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                
                string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Role FROM Users WHERE Username = @Username AND UserPassword = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object roleObj = cmd.ExecuteScalar();

                        if (roleObj != null)
                        {
                            string role = roleObj.ToString();
                            if (role.Equals("admin", StringComparison.OrdinalIgnoreCase))
                            {
                                frmAdminDashboard adminForm = new frmAdminDashboard();
                                adminForm.Username = txtUsername.Text;
                                txtUsername.Clear();
                                txtPassword.Clear();
                                adminForm.Show();
                                this.Hide();
                            }
                            else if (role.Equals("user", StringComparison.OrdinalIgnoreCase))
                            {
                                frmUserDashboard userForm = new frmUserDashboard();
                                userForm.Username = txtUsername.Text;
                                txtUsername.Clear();
                                txtPassword.Clear();
                                userForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Unknown role detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }    

        private void groupBoxLogin_Enter(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
