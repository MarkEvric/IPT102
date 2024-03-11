#nullable disable
using Microsoft.Data.SqlClient;
using Dapper;
using QuinonesBlazor.Model;
using System.Data;
using System;

namespace QuinonesBlazor.DB_Store
{
    public class IndexDb
    {
        private readonly SqlConnection konek;
        private readonly IConfiguration config;

        public IndexDb(IConfiguration _config)
        {
            config = _config;
            konek = new SqlConnection(config.GetConnectionString("mark"));
        }
        public void Create(Person NewPerson)
        {
            var sqlstring = "[dbo].[NewContact]";
            var parameter = new DynamicParameters();
            parameter.Add("@FirstName", NewPerson.FirstName, DbType.String, ParameterDirection.Input);
            parameter.Add("@LastName", NewPerson.LastName, DbType.String, ParameterDirection.Input);
            parameter.Add("@Email", NewPerson.Email, DbType.String, ParameterDirection.Input);
            parameter.Add("@MobileNumber", NewPerson.MobileNumber, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@PAddress", NewPerson.PAddress, DbType.String, ParameterDirection.Input);
            konek.Execute(sqlstring, parameter, commandType: CommandType.StoredProcedure);
        }
    }
}
