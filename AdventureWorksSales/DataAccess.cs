using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace AdventureWorksSales
{
    class DataAccess
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;

        public List<Customer> GetCustomers()
        {
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT PersonID, CustomerID, FirstName, LastName FROM " +
                    "Sales.Customer INNER JOIN Person.Person ON PersonID=BusinessEntityID " +
                    "WHERE PersonID IS NOT NULL";
                var customers = connection.Query<Customer>(sql).ToList();
                return customers;
            }
        }

        public static List<SalesOrderHeader> GetOrderHeader(int customerID)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT [SalesOrderID]
                                      ,[OrderDate]
                                      ,[Status]
                                      ,SalesOrderHeader.[CustomerID]
                                      ,[SubTotal]
	                                  ,[TaxAmt]
	                                  ,[Freight]
                                      ,[TotalDue]
                                      ,[Comment]
                            FROM [AdventureWorks2016].[Sales].[SalesOrderHeader]
                            INNER JOIN Sales.Customer ON SalesOrderHeader.CustomerID=Customer.CustomerID
                            INNER JOIN Person.Person ON PersonID=BusinessEntityID
                            WHERE PersonID IS NOT NULL AND Sales.Customer.CustomerID = {customerID}";
                var orderHeaders = connection.Query<SalesOrderHeader>(sql).ToList();
                return orderHeaders;
            }
        }


        public static List<SalesOrderHeader> GetOrderDetails(int salesOrderId)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT [SalesOrderDetailID]
                              ,[OrderQty]
                              ,SalesOrderDetail.[ProductID]
                              , Product.Name AS ProductName
                              ,[UnitPrice]
                              ,[LineTotal] 
                            FROM [Sales].[SalesOrderDetail] 
                            INNER JOIN Production.Product ON SalesOrderDetail.ProductID=Product.ProductID 
                            WHERE SalesOrderID = {salesOrderId}";
                var details = connection.Query<SalesOrderHeader>(sql).ToList();
                return details;
            }
        }
        
    }
}
