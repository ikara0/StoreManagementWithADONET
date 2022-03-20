using BilgeAdam.Data.Entities;
using System.Data.SqlClient;

namespace BilgeAdam.Data.Abstractions
{
    public interface IProductService
    {
        List<Product> GetAllProduct();
        int GetTotalCount();
        void GetProductByOffSet(int pageIndex, int pageSize, Action<SqlDataReader> mapperProduct);
    }
}
