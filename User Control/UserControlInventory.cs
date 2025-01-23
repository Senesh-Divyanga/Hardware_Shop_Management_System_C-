using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hardware_shop.User_Control
{
    public partial class UserControlInventory : UserControl
    {
        public UserControlInventory()
        {
            InitializeComponent();
            LoadInventoryData();
            CustomizeDataGridView(dataInventory);
        }

        private void LoadInventoryData()
        {
            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "SELECT * FROM Inventory";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable salesTable = new DataTable();
                    adapter.Fill(salesTable);

                    dataInventory.DataSource = salesTable;
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

         private void CustomizeDataGridView(DataGridView dgv)
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



        private void UserControlInventory_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInventoryName.Text = "";
            txtInventoryQuantity.Text = "";
            txtInventoryType.Text = "";
        }

        private void btnUpdateClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnAddInventory_Click_1(object sender, EventArgs e)
        {
            string inventoryName = txtInventoryName.Text;
            string inventoryType = txtInventoryType.Text;
            string quantityText = txtInventoryQuantity.Text;
            string unitPriceText = txtUnitPrice.Text;
            string supplier = txtSupplier.Text;

            if (string.IsNullOrWhiteSpace(inventoryName) || string.IsNullOrWhiteSpace(inventoryType) || string.IsNullOrWhiteSpace(quantityText) || string.IsNullOrWhiteSpace(unitPriceText))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (!int.TryParse(quantityText, out int inventoryQuantity) || inventoryQuantity < 0)
            {
                MessageBox.Show("Quantity must be a non-negative number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(unitPriceText, out int unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Unit Price must be a non-negative number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Inventory (InventoryName, InventoryType, InventoryQuantity, UnitPrice, SupplierID) " +
                                   "VALUES (@InventoryName, @InventoryType, @InventoryQuantity, @UnitPrice, @SupplierID)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int supplierId = GetSupplierIdByName(supplier);

                        cmd.Parameters.AddWithValue("@InventoryName", inventoryName);
                        cmd.Parameters.AddWithValue("@InventoryType", inventoryType);
                        cmd.Parameters.AddWithValue("@InventoryQuantity", inventoryQuantity);
                        cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inventory item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadInventoryData();

                            txtInventoryName.Text = "";
                            txtInventoryType.Text = "";
                            txtInventoryQuantity.Text = "";
                            txtUnitPrice.Text = "";
                            txtSupplier.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert inventory item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSupplierIdByName(string supplierName)
        {
            int supplierId = -1;
            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SupplierID FROM Suppliers WHERE SupplierName = @SupplierName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierName", supplierName);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        supplierId = Convert.ToInt32(result);
                    }
                }
            }
            return supplierId;
        }


        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtInventoryName.Text = "";
            txtInventoryType.Text = "";
            txtInventoryQuantity.Text = "";
            txtUnitPrice.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInventoryName.Text))
            {
                MessageBox.Show("Please enter a valid Supplier Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            string query = "DELETE FROM Inventory WHERE InventoryName = @InventoryName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@InventoryName", txtInventoryName.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inventory deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No user found with the given First Name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        LoadInventoryData();
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
            txtInventoryName.Text = "";
            txtInventoryType.Text = "";
            txtInventoryQuantity.Text = "";
            txtUnitPrice.Text = "";
        }

        private void btnSearchInventory_Click(object sender, EventArgs e)
        {
            string inventoryName = txtInventoryName.Text.Trim();

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query;

            if (string.IsNullOrWhiteSpace(inventoryName))
            {
                query = "SELECT * FROM Inventory";
            }
            else
            {
                query = "SELECT * FROM Inventory WHERE InventoryName = @inventoryName";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(inventoryName))
                        {
                            command.Parameters.AddWithValue("@inventoryName", inventoryName);
                        }

                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataInventory.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No Inventory found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string inventoryName = txtInventoryName.Text.Trim();
            string inventoryType = txtInventoryType.Text.Trim();
            string inventoryQuantityText = txtInventoryQuantity.Text.Trim();
            string unitPriceText = txtUnitPrice.Text.Trim();
            string supplierName = txtSupplier.Text.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(inventoryName) || string.IsNullOrWhiteSpace(inventoryType) ||
                string.IsNullOrWhiteSpace(inventoryQuantityText) || string.IsNullOrWhiteSpace(unitPriceText) ||
                string.IsNullOrWhiteSpace(supplierName))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(inventoryQuantityText, out int inventoryQuantity) || inventoryQuantity < 0)
            {
                MessageBox.Show("Inventory Quantity must be a non-negative number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(unitPriceText, out int unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Unit Price must be a non-negative number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int supplierID = GetSupplierIdByName(supplierName);
            if (supplierID == -1)
            {
                MessageBox.Show("Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "UPDATE Inventory SET InventoryName = @inventoryName, InventoryType = @inventoryType, " +
                           "InventoryQuantity = @inventoryQuantity, UnitPrice = @unitPrice, SupplierID = @supplierID " +
                           "WHERE InventoryName = @inventoryName"; 

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inventoryName", inventoryName);
                        command.Parameters.AddWithValue("@inventoryType", inventoryType);
                        command.Parameters.AddWithValue("@inventoryQuantity", inventoryQuantity);
                        command.Parameters.AddWithValue("@unitPrice", unitPrice);
                        command.Parameters.AddWithValue("@supplierID", supplierID);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inventory details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGridView(connection); 
                        }
                        else
                        {
                            MessageBox.Show("No Inventory found with the entered Inventory Name.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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
            string query = "SELECT * FROM Inventory";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataInventory.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while refreshing the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
