using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorksSales
{
    public partial class MainForm : Form
    {
        int customerId;
        public MainForm()
        {
            InitializeComponent();
        }

        private void salesListBox_DoubleClick(object sender, EventArgs e)
        {
            SalesOrderHeader order = ((SalesOrderHeader)salesListBox.SelectedItem);

            Form details = new OrderDetails(order);

            details.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            List<Customer> customer = new List<Customer>();

            customer = db.GetCustomers();

            foreach (Customer cust in customer)
            {
                customersComboBox.Items.Add(cust);
            }
        }

        private void customersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int customerId = ((Customer)sender).CustomerID;
            customerId = ((Customer)customersComboBox.SelectedItem).CustomerID;
            salesListBox.Items.Clear();

            DataAccess db = new DataAccess();

            List<SalesOrderHeader> salesOrder = new List<SalesOrderHeader>();

            salesOrder = db.GetOrderHeader(customerId);

            foreach (SalesOrderHeader sale in salesOrder)
            {
                salesListBox.Items.Add(sale);
            }
        }
    }
}
