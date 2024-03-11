#nullable disable
using Microsoft.Data.SqlClient;
using Dapper;
using System.Data;
using QuinonesBlazor.Model;
using System;

namespace QuinonesBlazor.DB_Store
{
    public class DisplayContactDb
    {
        private readonly SqlConnection konek;
        private readonly IConfiguration config;
        public DisplayContactDb(IConfiguration _config)
        {
            config = _config;
            konek = new SqlConnection(config.GetConnectionString("mark"));
        }

        public IEnumerable<Person> list()
        {
            var sqlstring = "[dbo].[optionsDisplay]";
            return konek.Query<Person>(sqlstring);
        }
        public IEnumerable<Person> SelectedContact(int PersonId)
        {
            var sqlstring = "[dbo].[selectedContact]";
            var parameter = new { PersonId = PersonId };
            return konek.Query<Person>(sqlstring, parameter);
        }
        public void deleteContact(int PersonId)
        {
            var sqlstring = "[dbo].[DeleteContact]";
            var parameter = new { PersonId = PersonId };
            konek.Execute(sqlstring, parameter, commandType: CommandType.StoredProcedure);
        }
    }
}
