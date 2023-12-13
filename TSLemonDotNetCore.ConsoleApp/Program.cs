using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
{
    DataSource = ".",
    InitialCatalog = "TestLemonDotNetCore",
    UserID = "sa",
    Password = "sasasu"
};

SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
connection.Open();
Console.WriteLine("Connection is opened");

string query = @"SELECT [Blog_Id]
      ,[Blog_Title]
      ,[Blog_Author]
      ,[Blog_Content]
  FROM [dbo].[Tbl_Blog]";

SqlCommand command = new SqlCommand(query, connection);
SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
DataTable dt = new DataTable();
sqlDataAdapter.Fill(dt);    

connection.Close();
Console.WriteLine("Connection is closed");

Console.ReadKey();