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
        public MainForm()
        {
            InitializeComponent();
        }

        private void salesListBox_DoubleClick(object sender, EventArgs e)
        {

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

        }
    }
}
