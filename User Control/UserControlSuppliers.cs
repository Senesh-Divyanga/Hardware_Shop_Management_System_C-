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
    public partial class UserControlSuppliers : UserControl
    {
        public UserControlSuppliers()
        {
            InitializeComponent();
            LoadSupplierData();
            BeautifyDataGridView(dataSuppliers);

        }

        private void LoadSupplierData()
        {
            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "SELECT * FROM Suppliers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable salesTable = new DataTable();
                    adapter.Fill(salesTable);

                    dataSuppliers.DataSource = salesTable;
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

        private void btnClearsuppliers_Click(object sender, EventArgs e)
        {
            txtNamesuppliers.Text = "";
            txtNumbersuppliers.Text = "";
        }

        private void UserControlSuppliers_Load(object sender, EventArgs e)
        {

        }

        private void btnAddsuppliers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamesuppliers.Text) ||
                string.IsNullOrWhiteSpace(txtNumbersuppliers.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNumbersuppliers.Text.Length != 10)
            {
                MessageBox.Show("Please enter a valid 10-digit contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string supplierName = txtNamesuppliers.Text;
            string supplierContact = txtNumbersuppliers.Text;

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "INSERT INTO Suppliers (SupplierName, SupplierContactNumber) VALUES (@supplierName, @supplierContact)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@supplierName", supplierName);
                        command.Parameters.AddWithValue("@supplierContact", supplierContact);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadSupplierData();
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



        private void btnDeletesuppliers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamesuppliers.Text))
            {
                MessageBox.Show("Please enter a valid Supplier Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to delete this Supplier?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "DELETE FROM Suppliers WHERE SupplierName = @SupplierName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SupplierName", txtNamesuppliers.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No user found with the given First Name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        LoadSupplierData();
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
            txtNamesuppliers.Text = "";
            txtNumbersuppliers.Text = "";
        }

        private void btnSearchsuppliers_Click(object sender, EventArgs e)
        {
            string supplierName = txtNamesuppliers.Text.Trim();

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query;

            if (string.IsNullOrWhiteSpace(supplierName))
            {
                query = "SELECT * FROM Suppliers";
            }
            else
            {
                query = "SELECT * FROM Suppliers WHERE SupplierName = @supplierName";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(supplierName))
                        {
                            command.Parameters.AddWithValue("@supplierName", supplierName);
                        }

                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataSuppliers.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No Supplier found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatesuppliers_Click(object sender, EventArgs e)
        {
            string supplierName = txtNamesuppliers.Text.Trim();
            string supplierContactNumber = txtNumbersuppliers.Text.Trim();

            if (string.IsNullOrWhiteSpace(supplierName))
            {
                MessageBox.Show("Please enter the First Name to update the record.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "UPDATE Suppliers SET SupplierName = @supplierName, SupplierContactNumber = @supplierContactNumber WHERE SupplierName = @supplierName";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@supplierName", supplierName);
                        command.Parameters.AddWithValue("@supplierContactNumber", supplierContactNumber);


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

        private void RefreshDataGridView(SqlConnection connection)
        {
            string query = "SELECT * FROM Suppliers";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataSuppliers.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while refreshing the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
