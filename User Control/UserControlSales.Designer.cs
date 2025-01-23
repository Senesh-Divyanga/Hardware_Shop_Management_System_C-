namespace Hardware_shop.User_Control
{
    partial class UserControlSales
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSales = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.inverntoryname = new System.Windows.Forms.Label();
            this.txtInventoryName = new System.Windows.Forms.TextBox();
            this.inventorytype = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.btnUpdatesale = new System.Windows.Forms.Button();
            this.btnClearsale = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnSearchsale = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hardware_ShopDataSet1 = new Hardware_shop.Hardware_ShopDataSet1();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter1 = new Hardware_shop.Hardware_ShopDataSet1TableAdapters.InventoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_ShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Management";
            // 
            // dataSales
            // 
            this.dataSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSales.Location = new System.Drawing.Point(47, 368);
            this.dataSales.Name = "dataSales";
            this.dataSales.RowHeadersWidth = 51;
            this.dataSales.RowTemplate.Height = 24;
            this.dataSales.Size = new System.Drawing.Size(1027, 218);
            this.dataSales.TabIndex = 1;
            this.dataSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSales_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(325, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(403, 34);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // inverntoryname
            // 
            this.inverntoryname.AutoSize = true;
            this.inverntoryname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverntoryname.Location = new System.Drawing.Point(71, 98);
            this.inverntoryname.Name = "inverntoryname";
            this.inverntoryname.Size = new System.Drawing.Size(226, 32);
            this.inverntoryname.TabIndex = 3;
            this.inverntoryname.Text = "Inventory Name";
            // 
            // txtInventoryName
            // 
            this.txtInventoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryName.Location = new System.Drawing.Point(325, 96);
            this.txtInventoryName.Name = "txtInventoryName";
            this.txtInventoryName.Size = new System.Drawing.Size(231, 34);
            this.txtInventoryName.TabIndex = 4;
            // 
            // inventorytype
            // 
            this.inventorytype.AutoSize = true;
            this.inventorytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorytype.Location = new System.Drawing.Point(603, 98);
            this.inventorytype.Name = "inventorytype";
            this.inventorytype.Size = new System.Drawing.Size(214, 32);
            this.inventorytype.TabIndex = 3;
            this.inventorytype.Text = "Inventory Type";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(599, 151);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(129, 32);
            this.quantity.TabIndex = 3;
            this.quantity.Text = "Quantity";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(71, 212);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(78, 32);
            this.date.TabIndex = 3;
            this.date.Text = "Date";
            // 
            // btnUpdatesale
            // 
            this.btnUpdatesale.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdatesale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatesale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatesale.ForeColor = System.Drawing.Color.White;
            this.btnUpdatesale.Location = new System.Drawing.Point(559, 292);
            this.btnUpdatesale.Name = "btnUpdatesale";
            this.btnUpdatesale.Size = new System.Drawing.Size(138, 54);
            this.btnUpdatesale.TabIndex = 41;
            this.btnUpdatesale.Text = "Update";
            this.btnUpdatesale.UseVisualStyleBackColor = false;
            this.btnUpdatesale.Click += new System.EventHandler(this.btnUpdatesale_Click);
            // 
            // btnClearsale
            // 
            this.btnClearsale.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClearsale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearsale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearsale.ForeColor = System.Drawing.Color.White;
            this.btnClearsale.Location = new System.Drawing.Point(719, 292);
            this.btnClearsale.Name = "btnClearsale";
            this.btnClearsale.Size = new System.Drawing.Size(138, 54);
            this.btnClearsale.TabIndex = 38;
            this.btnClearsale.Text = "Clear";
            this.btnClearsale.UseVisualStyleBackColor = false;
            this.btnClearsale.Click += new System.EventHandler(this.btnClearsale_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(217, 292);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(138, 54);
            this.btnSell.TabIndex = 37;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnSearchsale
            // 
            this.btnSearchsale.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchsale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchsale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchsale.ForeColor = System.Drawing.Color.White;
            this.btnSearchsale.Location = new System.Drawing.Point(389, 292);
            this.btnSearchsale.Name = "btnSearchsale";
            this.btnSearchsale.Size = new System.Drawing.Size(138, 54);
            this.btnSearchsale.TabIndex = 39;
            this.btnSearchsale.Text = "Search";
            this.btnSearchsale.UseVisualStyleBackColor = false;
            this.btnSearchsale.Click += new System.EventHandler(this.btnSearchsale_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(325, 151);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(230, 34);
            this.txtCustomer.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(853, 151);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(230, 34);
            this.txtQuantity.TabIndex = 42;
            // 
            // comboType
            // 
            this.comboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(853, 98);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(238, 37);
            this.comboType.TabIndex = 43;
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataMember = "Inventory";
            this.inventoryBindingSource1.DataSource = this.hardware_ShopDataSet1;
            // 
            // hardware_ShopDataSet1
            // 
            this.hardware_ShopDataSet1.DataSetName = "Hardware_ShopDataSet1";
            this.hardware_ShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            // 
            // inventoryTableAdapter1
            // 
            this.inventoryTableAdapter1.ClearBeforeFill = true;
            // 
            // UserControlSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnUpdatesale);
            this.Controls.Add(this.btnSearchsale);
            this.Controls.Add(this.btnClearsale);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtInventoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.inventorytype);
            this.Controls.Add(this.inverntoryname);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataSales);
            this.Controls.Add(this.label1);
            this.Name = "UserControlSales";
            this.Size = new System.Drawing.Size(1123, 609);
            this.Load += new System.EventHandler(this.UserControlSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_ShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataSales;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label inverntoryname;
        private System.Windows.Forms.TextBox txtInventoryName;
        private System.Windows.Forms.Label inventorytype;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button btnUpdatesale;
        private System.Windows.Forms.Button btnClearsale;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnSearchsale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private Hardware_ShopDataSet hardware_ShopDataSet;
        private Hardware_ShopDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private Hardware_ShopDataSet1 hardware_ShopDataSet1;
        private Hardware_ShopDataSet1TableAdapters.InventoryTableAdapter inventoryTableAdapter1;
    }
}
