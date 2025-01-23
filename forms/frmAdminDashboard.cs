using Hardware_shop.User_Control;
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

namespace Hardware_shop.forms
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }



        public string Username;


        private void MovePanel(Control btn)
        {
            movePanel.Top = btn.Top;
            movePanel.Height = btn.Height;
        }

        private void a_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(minimize, "Minimize");
        }

        private void PIcClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(PIcClose, "Close");
        }

        private void PIcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                this.Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
            else
            {
                return;
            }
        }

        private void movePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            MovePanel(btnInventory);
            panelMain.Controls.Clear();

            UserControlInventory inventoryControl = new UserControlInventory();
            inventoryControl.Dock = DockStyle.Fill;

            panelMain.Controls.Add(inventoryControl);

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            MovePanel(btnSales);
            panelMain.Controls.Clear();

            UserControlSales salesControl = new UserControlSales();
            salesControl.Dock = DockStyle.Fill;

            panelMain.Controls.Add(salesControl);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            MovePanel(btnCustomers);
            panelMain.Controls.Clear();

            UserControlCustomers customerControl = new UserControlCustomers();
            customerControl.Dock = DockStyle.Fill;

            panelMain.Controls.Add(customerControl);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            MovePanel(btnSuppliers);
            panelMain.Controls.Clear();

            UserControlSuppliers supplierControl = new UserControlSuppliers();
            supplierControl.Dock = DockStyle.Fill;

            panelMain.Controls.Add(supplierControl);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            MovePanel(btnUsers);
            panelMain.Controls.Clear();

            UserControlUser1 userControl = new UserControlUser1();
            userControl.Dock = DockStyle.Fill;

            panelMain.Controls.Add(userControl);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Username;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
          
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

