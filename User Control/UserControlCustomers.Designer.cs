namespace Hardware_shop.User_Control
{
    partial class UserControlCustomers
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
            this.txtCustormerName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustormerNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataCustomers = new System.Windows.Forms.DataGridView();
            this.btnUpdatecustormer = new System.Windows.Forms.Button();
            this.btnDeletecustormer = new System.Windows.Forms.Button();
            this.btnSearchcustormer = new System.Windows.Forms.Button();
            this.btnClearcustormer = new System.Windows.Forms.Button();
            this.btnAddcustormer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Management";
            // 
            // txtCustormerName
            // 
            this.txtCustormerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustormerName.Location = new System.Drawing.Point(535, 140);
            this.txtCustormerName.Name = "txtCustormerName";
            this.txtCustormerName.Size = new System.Drawing.Size(274, 34);
            this.txtCustormerName.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full Name";
            // 
            // txtCustormerNumber
            // 
            this.txtCustormerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustormerNumber.Location = new System.Drawing.Point(535, 206);
            this.txtCustormerNumber.Name = "txtCustormerNumber";
            this.txtCustormerNumber.Size = new System.Drawing.Size(274, 34);
            this.txtCustormerNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact Number";
            // 
            // dataCustomers
            // 
            this.dataCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomers.Location = new System.Drawing.Point(47, 368);
            this.dataCustomers.Name = "dataCustomers";
            this.dataCustomers.RowHeadersWidth = 51;
            this.dataCustomers.RowTemplate.Height = 24;
            this.dataCustomers.Size = new System.Drawing.Size(1027, 218);
            this.dataCustomers.TabIndex = 4;
            // 
            // btnUpdatecustormer
            // 
            this.btnUpdatecustormer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdatecustormer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatecustormer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatecustormer.ForeColor = System.Drawing.Color.White;
            this.btnUpdatecustormer.Location = new System.Drawing.Point(522, 292);
            this.btnUpdatecustormer.Name = "btnUpdatecustormer";
            this.btnUpdatecustormer.Size = new System.Drawing.Size(138, 54);
            this.btnUpdatecustormer.TabIndex = 46;
            this.btnUpdatecustormer.Text = "Update";
            this.btnUpdatecustormer.UseVisualStyleBackColor = false;
            this.btnUpdatecustormer.Click += new System.EventHandler(this.btnUpdatecustormer_Click);
            // 
            // btnDeletecustormer
            // 
            this.btnDeletecustormer.BackColor = System.Drawing.Color.Red;
            this.btnDeletecustormer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletecustormer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletecustormer.ForeColor = System.Drawing.Color.White;
            this.btnDeletecustormer.Location = new System.Drawing.Point(840, 292);
            this.btnDeletecustormer.Name = "btnDeletecustormer";
            this.btnDeletecustormer.Size = new System.Drawing.Size(138, 54);
            this.btnDeletecustormer.TabIndex = 45;
            this.btnDeletecustormer.Text = "Delete";
            this.btnDeletecustormer.UseVisualStyleBackColor = false;
            this.btnDeletecustormer.Click += new System.EventHandler(this.btnDeletecustormer_Click);
            // 
            // btnSearchcustormer
            // 
            this.btnSearchcustormer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchcustormer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchcustormer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchcustormer.ForeColor = System.Drawing.Color.White;
            this.btnSearchcustormer.Location = new System.Drawing.Point(352, 292);
            this.btnSearchcustormer.Name = "btnSearchcustormer";
            this.btnSearchcustormer.Size = new System.Drawing.Size(138, 54);
            this.btnSearchcustormer.TabIndex = 44;
            this.btnSearchcustormer.Text = "Search";
            this.btnSearchcustormer.UseVisualStyleBackColor = false;
            this.btnSearchcustormer.Click += new System.EventHandler(this.btnSearchcustormer_Click);
            // 
            // btnClearcustormer
            // 
            this.btnClearcustormer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClearcustormer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearcustormer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearcustormer.ForeColor = System.Drawing.Color.White;
            this.btnClearcustormer.Location = new System.Drawing.Point(682, 292);
            this.btnClearcustormer.Name = "btnClearcustormer";
            this.btnClearcustormer.Size = new System.Drawing.Size(138, 54);
            this.btnClearcustormer.TabIndex = 43;
            this.btnClearcustormer.Text = "Clear";
            this.btnClearcustormer.UseVisualStyleBackColor = false;
            this.btnClearcustormer.Click += new System.EventHandler(this.btnClearcustormer_Click);
            // 
            // btnAddcustormer
            // 
            this.btnAddcustormer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddcustormer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddcustormer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddcustormer.ForeColor = System.Drawing.Color.White;
            this.btnAddcustormer.Location = new System.Drawing.Point(180, 292);
            this.btnAddcustormer.Name = "btnAddcustormer";
            this.btnAddcustormer.Size = new System.Drawing.Size(138, 54);
            this.btnAddcustormer.TabIndex = 42;
            this.btnAddcustormer.Text = "Add";
            this.btnAddcustormer.UseVisualStyleBackColor = false;
            this.btnAddcustormer.Click += new System.EventHandler(this.btnAddcustormer_Click);
            // 
            // UserControlCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdatecustormer);
            this.Controls.Add(this.btnDeletecustormer);
            this.Controls.Add(this.btnSearchcustormer);
            this.Controls.Add(this.btnClearcustormer);
            this.Controls.Add(this.btnAddcustormer);
            this.Controls.Add(this.dataCustomers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustormerNumber);
            this.Controls.Add(this.txtCustormerName);
            this.Controls.Add(this.label1);
            this.Name = "UserControlCustomers";
            this.Size = new System.Drawing.Size(1123, 609);
            this.Load += new System.EventHandler(this.UserControlCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustormerName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustormerNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataCustomers;
        private System.Windows.Forms.Button btnUpdatecustormer;
        private System.Windows.Forms.Button btnDeletecustormer;
        private System.Windows.Forms.Button btnSearchcustormer;
        private System.Windows.Forms.Button btnClearcustormer;
        private System.Windows.Forms.Button btnAddcustormer;
    }
}
