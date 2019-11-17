using Northwind.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUI.Forms.FormOrders
{
    public partial class FormOrdersTable : Form
    {
        public FormOrdersTable()
        {
            InitializeComponent();
        }
        OrderController orderController = new OrderController();
        private void FormOrdersTable_Load(object sender, EventArgs e)
        {
            dataGridOrders.DataSource = orderController.GetOrderList();
            #region Resize the order table

            dataGridOrders.Columns["Employee"].Visible = false;
            dataGridOrders.Columns["Shipper"].Visible = false;
            dataGridOrders.Columns["Order_Details"].Visible = false;
            dataGridOrders.Columns["Customer"].Visible = false;
            dataGridOrders.Columns["CustomerID"].Visible = false;
            dataGridOrders.Columns["EmployeeID"].Visible = false;
            dataGridOrders.Columns["ShipVia"].Visible = false;
            dataGridOrders.Columns["CustomerCompany"].MinimumWidth = 170;
            dataGridOrders.Columns["OrderID"].Width = 60;
            dataGridOrders.Columns["OrderDate"].Width = 85;
            dataGridOrders.Columns["RequiredDate"].Width = 85;
            dataGridOrders.Columns["ShippedDate"].Width = 85;
            dataGridOrders.Columns["Freight"].Width = 85;
            dataGridOrders.Columns["ShipName"].Width = 150;
            dataGridOrders.Columns["ShipAddress"].Width = 245;
            #endregion

        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            FormPlaceOrder formPlaceOrder = new FormPlaceOrder();
            formPlaceOrder.ShowDialog();
        }
    }
}
