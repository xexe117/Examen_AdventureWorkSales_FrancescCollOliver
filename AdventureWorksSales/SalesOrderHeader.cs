using System;

namespace AdventureWorksSales
{
    public class SalesOrderHeader
    {
        public int SalesOrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int Status { get; set; }
        public int CustomerID { get; set; }
        public decimal Subtotal { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal Freight { get; set; }
        public decimal TotalDue { get; set; }
        public string Comment { get; set; }
        public int OrderQty { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }


        public override string ToString()
        {
            string status;
            switch (Status)
            {
                case 1:
                    status = "In process";
                    break;
                case 2:
                    status = "Approved";
                    break;
                case 3:
                    status = "Backordered";
                    break;
                case 4:
                    status = "Rejected";
                    break;
                case 5:
                    status = "Shipped";
                    break;
                case 6:
                    status = "Cancelled";
                    break;
                default:
                    status = "Error";
                    break;
            }

            return "SalesOrderID: " + SalesOrderID + ", " + "OrderDate: " + OrderDate.ToShortDateString() + ", " + "Status:" + status + ", " +
                "Subtotal: " + Subtotal.ToString("C2") + ", " + "TaxAmt: " + TaxAmt.ToString("C2") + ", " + "Shipping: " + Freight.ToString("C2")
                + ", " + "Total: " + TotalDue.ToString("C2");
        }

        public string details
        {
            get
            {
                return $"Qty: {OrderQty}  Product: {ProductName}  UnitiPrice: {UnitPrice.ToString("C2")}  Line Total: { LineTotal.ToString("C2") }";
            }
        }
    }
}