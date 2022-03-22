using BilgeAdam.Data.Dtos;
using BilgeAdam.Data.Entities;
using System.ComponentModel;
using System.Data.SqlClient;

namespace BilgeAdam.Data.Abstractions
{
    public interface IProductService
    {
        List<Product> GetAllProduct();
        int GetTotalCount();
        void GetProductByOffSet(int pageIndex, int pageSize, Action<SqlDataReader> mapperProduct);
        List<ComboBoxItemDto> GetSuppliers();
        List<ComboBoxItemDto> GetCategories();
        void GetFilterData(string query, Action<SqlDataReader> mapperProduct);
    }
}
