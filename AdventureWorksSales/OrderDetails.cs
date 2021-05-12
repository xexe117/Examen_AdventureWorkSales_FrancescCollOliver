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
    public partial class OrderDetails : Form
    {
        SalesOrderHeader order;

        public OrderDetails(SalesOrderHeader order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            customerTB.Text = order.CustomerID.ToString();
            orderDateTB.Text = order.OrderDate.ToString("dd/MM/yyyy");
            orderNumberTB.Text = order.SalesOrderID.ToString();
            subTotalTB.Text = order.Subtotal.ToString("c2");
            taxTB.Text = order.TaxAmt.ToString("c2");
            shippingTB.Text = order.Freight.ToString("c2");
            totalTB.Text = order.TotalDue.ToString("c2");


            DataAccess db = new DataAccess();
            List<SalesOrderHeader> sales = new List<SalesOrderHeader>();
            
            sales = db.GetOrderDetails(order.SalesOrderID);

            foreach (SalesOrderHeader sal in sales)
            {
                orderDetailsLB.Items.Add(sal.details);
            }


        }
    }
}
