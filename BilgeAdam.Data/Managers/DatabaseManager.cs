using BilgeAdam.Data.Dtos;
using BilgeAdam.Data.Entities;
using Dapper;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BilgeAdam.Data
{
    public class DatabaseManager
    {
        private readonly SqlConnection connection;
        public DatabaseManager()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString);
        }
        public bool Any(string query)
        {
            OpenConnection();
            var command = new SqlCommand(query, connection);
            var result = command.ExecuteScalar();
            CloseConnection();
            return result is not null;
        }

        public List<Product> GetAllWithDapper(string query)
        {
            OpenConnection();
            var result = connection.Query<Product>(query);
            CloseConnection();
            return result.ToList();
        }

        public List<ComboBoxItemDto> GetCategoriesWithDapper(string query)
        {
            OpenConnection();
            var result = connection.Query<ComboBoxItemDto>(query);
            CloseConnection();
            return result.ToList();
        }

        public int GetTotalCountWithDapper(string query)
        {
            OpenConnection();
            var result = connection.QueryFirst<int>(query);
            CloseConnection();
            return result;
        }

        private void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public TResult GetAll<TResult>(string tablename, Func<SqlDataReader, TResult> securityQuestionMapper)
        {
            OpenConnection();
            var command = new SqlCommand($"SELECT * FROM {tablename}", connection);
            var reader = command.ExecuteReader();
            var result = securityQuestionMapper(reader);
            CloseConnection();
            return result;
        }

        public List<ComboBoxItemDto> GetSuppliersWithDapper(string query)
        {

            OpenConnection();
            var result = connection.Query<ComboBoxItemDto>(query);
            CloseConnection();
            return result.ToList();
        }

        public void GetOffSetProduct(string query, Action<SqlDataReader> mapperProduct)
        {
            OpenConnection();
            var command = new SqlCommand(query, connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    mapperProduct(reader);
                }
            }
            CloseConnection();
        }


        private void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public bool Created(string query)
        {
            OpenConnection();
            var command = new SqlCommand(query, connection);
            var result = command.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }

        public bool ExecuteWithParameter(string query, SqlParameter[] sqlParameters)
        {
            OpenConnection();
            var command = new SqlCommand(query, connection);
            command.Parameters.AddRange(sqlParameters);
            var result = command.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }

        public TResult GetByQuery<TResult>(string query, Func<SqlDataReader, TResult> userMapper)
        {
            OpenConnection();
            var command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();
            var result = userMapper(reader);
            CloseConnection();
            return result;
        }

        public bool Update(string query)
        {
            OpenConnection();
            var command = new SqlCommand(query, connection);
            var result = command.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }
    }
}
