using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksSales
{
    class DetailsOrder
    {
        public int SalesOrderID { get; set; }
        public int OrderQty { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }

        public override string ToString()
        {
            return $"Qty: {OrderQty}  Product: {ProductName}  UnitiPrice: {UnitPrice}  Line Total: { LineTotal }";
        }
    }
}
