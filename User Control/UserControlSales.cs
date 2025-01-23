using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_shop.User_Control
{
    public partial class UserControlSales : UserControl
    {
        public UserControlSales()
        {
            InitializeComponent();
            LoadSalesData();
            CustomizeDataGridView(dataSales);
        }

        private void LoadSalesData()
        {
            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "SELECT * FROM Sales";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable salesTable = new DataTable();
                    adapter.Fill(salesTable);

                    dataSales.DataSource = salesTable;
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


        private void btnClearsale_Click(object sender, EventArgs e)
        {
            txtInventoryName.Text = "";
            comboType.Text = "";
            txtQuantity.Text = "";
            txtCustomer.Text = "";
        }

        private void LoadInventoryTypes()
        {
            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";
            string query = "SELECT DISTINCT InventoryType FROM Inventory";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            comboType.Items.Clear();

                            while (reader.Read())
                            {
                                comboType.Items.Add(reader["InventoryType"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading inventory types: {ex.Message}");
            }
        }


        private void UserControlSales_Load(object sender, EventArgs e)
        {
            LoadInventoryTypes();
        }


        private void btnSell_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInventoryName.Text) ||
                string.IsNullOrWhiteSpace(comboType.Text) ||
                string.IsNullOrWhiteSpace(txtCustomer.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string inventoryName = txtInventoryName.Text.Trim();
            string inventoryType = comboType.Text.Trim();
            string customerName = txtCustomer.Text.Trim();

            if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string inventoryQuery = @"SELECT InventoryID, UnitPrice FROM Inventory WHERE InventoryName = @InventoryName AND InventoryType = @InventoryType";
                    int inventoryID = 0;
                    decimal unitPrice = 0;

                    using (SqlCommand inventoryCommand = new SqlCommand(inventoryQuery, connection))
                    {
                        inventoryCommand.Parameters.AddWithValue("@InventoryName", inventoryName);
                        inventoryCommand.Parameters.AddWithValue("@InventoryType", inventoryType);

                        using (SqlDataReader reader = inventoryCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    inventoryID = reader["InventoryID"] != DBNull.Value ? Convert.ToInt32(reader["InventoryID"]) : 0;
                                    unitPrice = reader["UnitPrice"] != DBNull.Value ? Convert.ToDecimal(reader["UnitPrice"]) : 0;

                                    if (inventoryID <= 0 || unitPrice <= 0)
                                    {
                                        MessageBox.Show("Invalid inventory data retrieved. Please check the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Inventory item not found. Please check the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    decimal total = unitPrice * quantity;

                    string salesQuery = @"INSERT INTO Sales (InventoryID, InventoryName, CustomerID, InventoryQuantity, SaleDate, Total) 
                          VALUES (@InventoryID, @InventoryName, 
                          (SELECT CustomerID FROM Customers WHERE CustomerName = @CustomerName), 
                          @Quantity, @SaleDate, @Total)";

                    using (SqlCommand salesCommand = new SqlCommand(salesQuery, connection))
                    {
                        salesCommand.Parameters.AddWithValue("@InventoryID", inventoryID);
                        salesCommand.Parameters.AddWithValue("@InventoryName", inventoryName);
                        salesCommand.Parameters.AddWithValue("@CustomerName", customerName);
                        salesCommand.Parameters.AddWithValue("@Quantity", quantity);
                        salesCommand.Parameters.AddWithValue("@SaleDate", date);
                        salesCommand.Parameters.AddWithValue("@Total", total);

                        int rowsAffected = salesCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string receiptContent = $"--- Hardware Shop Receipt ---\n" +
                                                    $"Customer: {customerName}\n" +
                                                    $"Inventory Name: {inventoryName}\n" +
                                                    $"Inventory Type: {inventoryType}\n" +
                                                    $"Quantity: {quantity}\n" +
                                                    $"Total: Rs. {total}\n" +
                                                    $"Date: {date}\n" +
                                                    $"--------------------------------";

                            MessageBox.Show(receiptContent, "Sale Recorded Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DialogResult dialogResult = MessageBox.Show("Do you want to generate a receipt?", "Generate Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dialogResult == DialogResult.Yes)
                            {
                                GenerateReceiptFile(receiptContent, customerName);
                            }

                            LoadSalesData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to record sale. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GenerateReceiptFile(string receiptContent, string customerName)
        {
            try
            {
                if (string.IsNullOrEmpty(customerName))
                {
                    throw new ArgumentNullException(nameof(customerName), "Customer name cannot be null or empty.");
                }

                string receiptsFolder = Application.StartupPath + "\\Receipts";

                if (string.IsNullOrEmpty(receiptsFolder))
                {
                    throw new Exception("Application.StartupPath is null or invalid.");
                }

                if (!System.IO.Directory.Exists(receiptsFolder))
                {
                    System.IO.Directory.CreateDirectory(receiptsFolder);
                }

                string fileName = $"Receipt_{customerName}_{DateTime.Now:yyyyMMddHHmmss}.txt";
                string filePath = System.IO.Path.Combine(receiptsFolder, fileName);

                System.IO.File.WriteAllText(filePath, receiptContent);

                MessageBox.Show($"Receipt saved successfully at:\n{filePath}", "Receipt Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnDeletesale_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchsale_Click(object sender, EventArgs e)
        {
            string inventoryName = txtInventoryName.Text.Trim();

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query;

            if (string.IsNullOrWhiteSpace(inventoryName))
            {
                query = "SELECT * FROM Sales";
            }
            else
            {
                query = "SELECT * FROM Sales WHERE InventoryName = @inventoryName";
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

                        dataSales.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No Sale found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatesale_Click(object sender, EventArgs e)
        {
            string inventoryName = txtInventoryName.Text.Trim();
            string inventoryType = comboType.Text.Trim();
            string customerName = txtCustomer.Text.Trim();
            string quantity = txtQuantity.Text.Trim();

            if (string.IsNullOrWhiteSpace(inventoryName))
            {
                MessageBox.Show("Please enter the First Name to update the record.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=DESKTOP-U4JHOF2\\SQLEXPRESS;Initial Catalog=Hardware_Shop;Integrated Security=True;Encrypt=False";

            string query = "UPDATE Sales SET InventoryName = @inventoryName, InventoryType = @inventoryType,  InventoryQuantity = @quantity, CustomerName = customerName WHERE InventoryName = @inventoryName";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inventoryName", inventoryName);
                        command.Parameters.AddWithValue("@inventoryType", inventoryType);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@customerName", customerName);


                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sales details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No sale found with the entered First Name.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string query = "SELECT * FROM Sales";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataSales.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while refreshing the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter1.FillBy(this.hardware_ShopDataSet1.Inventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
