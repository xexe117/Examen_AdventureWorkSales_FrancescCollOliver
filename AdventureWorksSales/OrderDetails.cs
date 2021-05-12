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
        int OrderID;
        public OrderDetails(int OrderID)
        {
            InitializeComponent();
            this.OrderID = OrderID;
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
