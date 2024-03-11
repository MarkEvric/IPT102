#nullable disable
using Microsoft.Data.SqlClient;
using Dapper;
using QuinonesBlazor.Model;
using System.Data;
using System;

namespace QuinonesBlazor.DB_Store
{
    public class UpdateContactDb
    {
        private readonly SqlConnection konek;
        private readonly IConfiguration config;
        public UpdateContactDb(IConfiguration _config)
        {
            config = _config;
            konek = new SqlConnection(config.GetConnectionString("mark"));
        }

        public void updateContact(Person person)
        {
            var sqlstring = "[dbo].[Update Contact]";
            var parameter = new DynamicParameters();
            parameter.Add("@PersonId", person.PersonId, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@FirstName", person.FirstName, DbType.String, ParameterDirection.Input);
            parameter.Add("@LastName", person.LastName, DbType.String, ParameterDirection.Input);
            parameter.Add("@Email", person.Email, DbType.String, ParameterDirection.Input);
            parameter.Add("@MobileNumber", person.MobileNumber, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@PAddress", person.PAddress, DbType.String, ParameterDirection.Input);
            konek.Execute(sqlstring, parameter, commandType: CommandType.StoredProcedure);
        }
    }
}
