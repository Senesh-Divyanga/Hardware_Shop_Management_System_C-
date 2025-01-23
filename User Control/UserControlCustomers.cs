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
    public partial class UserControlCustomers : UserControl
    {
        public UserControlCustomers()
        {
            InitializeComponent();
            LoadCustomersData();
            BeautifyDataGridView(dataCustomers);


        }

        private void LoadCustomersData()
        {
            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "SELECT * FROM Customers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable salesTable = new DataTable();
                    adapter.Fill(salesTable);

                    dataCustomers.DataSource = salesTable;
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading customers data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearcustormer_Click(object sender, EventArgs e)
        {
            txtCustormerName.Text = "";
            txtCustormerNumber.Text = "";
        }

        private void UserControlCustomers_Load(object sender, EventArgs e)
        {

        }

        private void btnAddcustormer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustormerName.Text) ||
                string.IsNullOrWhiteSpace(txtCustormerNumber.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCustormerNumber.Text.Length != 10)
            {
                MessageBox.Show("Please enter a valid 10-digit contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerName = txtCustormerName.Text;
            string customerNumber = txtCustormerNumber.Text;

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "INSERT INTO Customers (CustomerName, CustomerContactNumber) VALUES (@customerName, @customerNumber)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@customerName", customerName);
                        command.Parameters.AddWithValue("@customerNumber", customerNumber);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadCustomersData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to record sale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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


        private void btnDeletecustormer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustormerName.Text))
            {
                MessageBox.Show("Please enter a valid Customer Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to delete this Inventory?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "DELETE FROM Customers WHERE CustomerName = @CustomerName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CustomerName", txtCustormerName.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No user found with the given First Name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        LoadCustomersData();
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
            txtCustormerName.Text = "";
            txtCustormerNumber.Text = "";
        }

        private void btnSearchcustormer_Click(object sender, EventArgs e)
        {
            string customerName = txtCustormerName.Text.Trim();

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query;

            if (string.IsNullOrWhiteSpace(customerName))
            {
                query = "SELECT * FROM Customers";
            }
            else
            {
                query = "SELECT * FROM Customers WHERE CustomerName = @customerName";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(customerName))
                        {
                            command.Parameters.AddWithValue("@customerName", customerName);
                        }

                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataCustomers.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No Customer found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatecustormer_Click(object sender, EventArgs e)
        {
            string customerName = txtCustormerName.Text.Trim();
            string customerNumber = txtCustormerNumber.Text.Trim();


            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Please enter the Customer Name to update the record.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "UPDATE Customers SET CustomerName = @customerName, CustomerContactNumber = @customerNumber,  CustomerAddress = @customerAddress WHERE CustomerName = @customerName";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@customerName", customerName);
                        command.Parameters.AddWithValue("@customerNumber", customerNumber);


                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No Inventory found with the entered First Name.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void RefreshDataGridView(SqlConnection connection)
        {
            string query = "SELECT * FROM Customers";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataCustomers.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while refreshing the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
