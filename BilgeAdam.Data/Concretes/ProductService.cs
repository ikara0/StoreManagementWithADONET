using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Dtos;
using BilgeAdam.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.Concretes
{
    public class ProductService : IProductService
    {
        private DatabaseManager databaseManager;
       
        public ProductService()
        {
            databaseManager = new DatabaseManager();   
        }

        public List<Product> GetAllProduct()
        {
            var query = "SELECT * FROM Products";
           return databaseManager.GetAllWithDapper(query);
        }

        public void GetProductByOffSet(int pageIndex, int pageSize, Action<SqlDataReader> mapperProduct)
        {
            var query = @$"SELECT p.ProductID AS Id,
                                 p.ProductName AS Name,
                                 p.UnitPrice AS Price,
                                 p.UnitsInStock AS Stock,
                                 c.CategoryName AS Category,
                                 s.CompanyName AS Company
                          FROM Products p
                          INNER JOIN Categories c ON c.CategoryID = p.CategoryID
                          INNER JOIN Suppliers s ON s.SupplierID = p.SupplierID
                          ORDER BY p.ProductID
                          OFFSET {pageIndex * pageSize} ROWS FETCH NEXT {pageSize} ROWS ONLY";
            databaseManager.GetOffSetProduct(query, mapperProduct);

        }

        public int GetTotalCount()
        {
            var query = "SELECT COUNT(0) FROM Products";
            return databaseManager.GetTotalCountWithDapper(query);
        }

        
    }
}
