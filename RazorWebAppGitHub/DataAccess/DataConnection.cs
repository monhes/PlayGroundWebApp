using Dapper;
using RazorWebAppGitHub.Models;
using System.Data;
using System.Data.SqlClient;

namespace RazorWebAppGitHub.DataAccess
{
    public class DataConnection
    {
        string connectionString = "Data Source=.;Initial Catalog=Sample;Integrated Security=True";
        public IEnumerable<People> GetConnect()
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            IEnumerable<People> PeopleList = connection.Query<People>("dbo.People_GetAll", new {}, commandType: CommandType.StoredProcedure).ToList<People>();
            return PeopleList;
        }
    }
}
