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

namespace Hardware_shop.User_Control
{
    public partial class UserControlUser1 : UserControl
    {
        public UserControlUser1()
        { 
            InitializeComponent();
            LoadUsersData();
            BeautifyDataGridView(dataUsers);

        }

        private void LoadUsersData()
        {
            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "SELECT * FROM Users";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable userTabel = new DataTable();
                    adapter.Fill(userTabel);

                    dataUsers.DataSource = userTabel;
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddUser1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string secondName = txtSecondName1.Text;
            string contactNumber = txtContactNumber1.Text;
            string NIC = txtNIC1.Text;
            string userName = txtUsername1.Text;
            string Password = txtPassword1.Text;
            string role = comboRole1.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(secondName) || string.IsNullOrWhiteSpace(contactNumber) || string.IsNullOrWhiteSpace(NIC) || string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (contactNumber.Length != 10)
            {
                MessageBox.Show("Contact number should be 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (NIC.Length != 12)
            {
                MessageBox.Show("NIC should be 12S digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    string query = "INSERT INTO Users (UserFirstName, UserSecondName, UserContactNumber, UserNIC, UserName, UserPassword, Role) VALUES (@firstName, @secondName, @contactNumber, @NIC, @userName, @Password, @role)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@secondName", secondName);
                        cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@NIC", NIC);
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@role", role);


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadUsersData();

                            txtFirstName.Clear();
                            txtSecondName1.Clear();
                            txtContactNumber1.Clear();
                            txtNIC1.Clear();
                            txtUsername1.Clear();
                            txtPassword1.Clear();
                            comboRole1.Items.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Failed to insert user item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtSecondName1.Text = "";
            txtContactNumber1.Text = "";
            txtNIC1.Text = "";
            txtUsername1.Text = "";
            txtPassword1.Text = "";
            comboRole1.Text = "";
        }

        private void dataUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter a valid First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "DELETE FROM Users WHERE UserFirstName = @FirstName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No user found with the given First Name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        LoadUsersData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ClearFormFields();
        }

        private void ClearFormFields()
        {
            txtFirstName.Text = "";
            txtSecondName1.Text = "";
            txtContactNumber1.Text = "";
            txtNIC1.Text = "";
            txtUsername1.Text = "";
            txtPassword1.Text = "";
            comboRole1.SelectedIndex = -1;
        }

        private void btnSearchUser1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query;

            if (string.IsNullOrWhiteSpace(firstName))
            {
                query = "SELECT * FROM Users";
            }
            else
            {
                query = "SELECT * FROM Users WHERE UserFirstName = @FirstName";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(firstName))
                        {
                            command.Parameters.AddWithValue("@FirstName", firstName);
                        }

                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataUsers.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No user found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string secondName = txtSecondName1.Text.Trim();
            string contactNumber = txtContactNumber1.Text.Trim();
            string nic = txtNIC1.Text.Trim();
            string userName = txtUsername1.Text.Trim();
            string password = txtPassword1.Text.Trim();
            string role = comboRole1.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Please enter the First Name to update the record.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "UPDATE Users SET UserSecondName = @SecondName, UserContactNumber = @ContactNumber, UserNIC = @NIC, UserName = @UserName, UserPassword = @Password, Role = @Role WHERE UserFirstName = @FirstName";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@SecondName", secondName);
                        command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        command.Parameters.AddWithValue("@NIC", nic);
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Role", role);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No user found with the entered First Name.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        RefreshDataGridView(connection);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BeautifyDataGridView(DataGridView dgv)
        {
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 175, 240);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.EnableHeadersVisualStyles = false;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Arial", 9);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 230, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.LightGray;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv.RowTemplate.Height = 30;

            dgv.RowHeadersVisible = false;

            dgv.BorderStyle = BorderStyle.None;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void RefreshDataGridView(SqlConnection connection)
        {
            string query = "SELECT * FROM Users";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataUsers.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while refreshing the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserControlUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
