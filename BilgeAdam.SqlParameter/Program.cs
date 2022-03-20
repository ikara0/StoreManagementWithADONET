using System.Data.SqlClient;

namespace BilgeAdam.SqlParameterPractice
{
    class Program
    {
        public static void Main(string[] arg)
        {
            string connectionString = "Server=localhost,12000;Database=Northwind;User Id=sa;Password=Bombabomba.com1";
            using var connection = new SqlConnection(connectionString);

            var query = "INSERT INTO Categories (CategoryName, Description) VALUES (@CategoryName, @Description)";
            connection.Open();
            var command = new SqlCommand(query, connection);
            var param1 = new SqlParameter("@CategoryName", "Deneme");
            var param2 = new SqlParameter("@Description", "Deneme verisidir");

            command.Parameters.AddRange(new SqlParameter[] { param1, param2 });

            var effectedRows = command.ExecuteNonQuery();
            Console.WriteLine(effectedRows);
        }
    }
}