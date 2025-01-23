namespace Hardware_shop.User_Control
{
    partial class UserControlUser1
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
            this.btnSearchUser1 = new System.Windows.Forms.Button();
            this.btnAddUser1 = new System.Windows.Forms.Button();
            this.dataUsers = new System.Windows.Forms.DataGridView();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.comboRole1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSecondName1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContactNumber1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNIC1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUsername1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchUser1
            // 
            this.btnSearchUser1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchUser1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser1.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser1.Location = new System.Drawing.Point(325, 287);
            this.btnSearchUser1.Name = "btnSearchUser1";
            this.btnSearchUser1.Size = new System.Drawing.Size(138, 54);
            this.btnSearchUser1.TabIndex = 37;
            this.btnSearchUser1.Text = "Search";
            this.btnSearchUser1.UseVisualStyleBackColor = false;
            this.btnSearchUser1.Click += new System.EventHandler(this.btnSearchUser1_Click);
            // 
            // btnAddUser1
            // 
            this.btnAddUser1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddUser1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser1.ForeColor = System.Drawing.Color.White;
            this.btnAddUser1.Location = new System.Drawing.Point(153, 287);
            this.btnAddUser1.Name = "btnAddUser1";
            this.btnAddUser1.Size = new System.Drawing.Size(138, 54);
            this.btnAddUser1.TabIndex = 36;
            this.btnAddUser1.Text = "Add ";
            this.btnAddUser1.UseVisualStyleBackColor = false;
            this.btnAddUser1.Click += new System.EventHandler(this.btnAddUser1_Click);
            // 
            // dataUsers
            // 
            this.dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsers.Location = new System.Drawing.Point(78, 358);
            this.dataUsers.Name = "dataUsers";
            this.dataUsers.RowHeadersWidth = 51;
            this.dataUsers.RowTemplate.Height = 24;
            this.dataUsers.Size = new System.Drawing.Size(993, 229);
            this.dataUsers.TabIndex = 35;
            this.dataUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUsers_CellContentClick);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(493, 287);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(138, 54);
            this.btnUpdateUser.TabIndex = 37;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnClear1
            // 
            this.btnClear1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear1.ForeColor = System.Drawing.Color.White;
            this.btnClear1.Location = new System.Drawing.Point(661, 287);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(138, 54);
            this.btnClear1.TabIndex = 37;
            this.btnClear1.Text = "Clear";
            this.btnClear1.UseVisualStyleBackColor = false;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUsers.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUsers.Location = new System.Drawing.Point(830, 287);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(138, 54);
            this.btnDeleteUsers.TabIndex = 37;
            this.btnDeleteUsers.Text = "Delete";
            this.btnDeleteUsers.UseVisualStyleBackColor = false;
            this.btnDeleteUsers.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(14, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(340, 42);
            this.label9.TabIndex = 38;
            this.label9.Text = "User Management";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(131, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 32);
            this.label10.TabIndex = 39;
            this.label10.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(373, 90);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(197, 34);
            this.txtFirstName.TabIndex = 40;
            // 
            // comboRole1
            // 
            this.comboRole1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRole1.FormattingEnabled = true;
            this.comboRole1.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboRole1.Location = new System.Drawing.Point(788, 181);
            this.comboRole1.Name = "comboRole1";
            this.comboRole1.Size = new System.Drawing.Size(197, 37);
            this.comboRole1.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(130, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 32);
            this.label11.TabIndex = 39;
            this.label11.Text = "Second Name";
            // 
            // txtSecondName1
            // 
            this.txtSecondName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName1.Location = new System.Drawing.Point(372, 136);
            this.txtSecondName1.Name = "txtSecondName1";
            this.txtSecondName1.Size = new System.Drawing.Size(197, 34);
            this.txtSecondName1.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(130, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 32);
            this.label12.TabIndex = 39;
            this.label12.Text = "Contact Number";
            // 
            // txtContactNumber1
            // 
            this.txtContactNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber1.Location = new System.Drawing.Point(372, 181);
            this.txtContactNumber1.Name = "txtContactNumber1";
            this.txtContactNumber1.Size = new System.Drawing.Size(197, 34);
            this.txtContactNumber1.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(130, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 32);
            this.label13.TabIndex = 39;
            this.label13.Text = "NIC";
            // 
            // txtNIC1
            // 
            this.txtNIC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC1.Location = new System.Drawing.Point(372, 226);
            this.txtNIC1.Name = "txtNIC1";
            this.txtNIC1.Size = new System.Drawing.Size(197, 34);
            this.txtNIC1.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(594, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 32);
            this.label14.TabIndex = 39;
            this.label14.Text = "UserName";
            // 
            // txtUsername1
            // 
            this.txtUsername1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername1.Location = new System.Drawing.Point(788, 90);
            this.txtUsername1.Name = "txtUsername1";
            this.txtUsername1.Size = new System.Drawing.Size(197, 34);
            this.txtUsername1.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(594, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 32);
            this.label15.TabIndex = 39;
            this.label15.Text = "Password";
            // 
            // txtPassword1
            // 
            this.txtPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword1.Location = new System.Drawing.Point(788, 136);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(197, 34);
            this.txtPassword1.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(594, 181);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 32);
            this.label16.TabIndex = 39;
            this.label16.Text = "Role";
            // 
            // UserControlUser1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboRole1);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.txtUsername1);
            this.Controls.Add(this.txtNIC1);
            this.Controls.Add(this.txtContactNumber1);
            this.Controls.Add(this.txtSecondName1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDeleteUsers);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnSearchUser1);
            this.Controls.Add(this.btnAddUser1);
            this.Controls.Add(this.dataUsers);
            this.Name = "UserControlUser1";
            this.Size = new System.Drawing.Size(1123, 609);
            this.Load += new System.EventHandler(this.UserControlUser1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserFirstName;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearchUser1;
        private System.Windows.Forms.Button btnAddUser1;
        private System.Windows.Forms.DataGridView dataUsers;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnDeleteUsers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox comboRole1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSecondName1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtContactNumber1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNIC1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUsername1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label label16;
    }
}
