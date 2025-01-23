using Hardware_shop.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_shop.forms
{
    public partial class frmUserDashboard : Form
    {
        public frmUserDashboard()
        {
            InitializeComponent();
        }

        public string Username;

        private void MovePanel(Control btn)
        {
            movePanel.Top = btn.Top;
            movePanel.Height = btn.Height;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimize_MouseHover(object sender, EventArgs e)
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void frmUserDashboard_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Username;
        }

        private void btnInventory_Click_1(object sender, EventArgs e)
        {
            MovePanel(btnInventory);
            userMainPanel.Controls.Clear();

            UserControlInventory inventoryControl = new UserControlInventory();
            inventoryControl.Dock = DockStyle.Fill;

            userMainPanel.Controls.Add(inventoryControl);
        }

        private void btnSales_Click_1(object sender, EventArgs e)
        {
            MovePanel(btnSales);
            userMainPanel.Controls.Clear();

            UserControlSales salesControl = new UserControlSales();
            salesControl.Dock = DockStyle.Fill;

            userMainPanel.Controls.Add(salesControl);
        }

        private void btnCustomers_Click_1(object sender, EventArgs e)
        {
            MovePanel(btnCustomers);
            userMainPanel.Controls.Clear();

            UserControlCustomers customerControl = new UserControlCustomers();
            customerControl.Dock = DockStyle.Fill;

            userMainPanel.Controls.Add(customerControl);
        }

        private void btnSuppliers_Click_1(object sender, EventArgs e)
        {
            MovePanel(btnSuppliers);
            userMainPanel.Controls.Clear();

            UserControlSuppliers supplierControl = new UserControlSuppliers();
            supplierControl.Dock = DockStyle.Fill;

            userMainPanel.Controls.Add(supplierControl);
        }

        private void userMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
