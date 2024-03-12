#nullable disable
using QuinonesBlazorIPT102.Model;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System;

namespace QuinonesBlazorIPT102.Connectionprofile
{
    public class Connectionprofile
    {
        private readonly SqlConnection sqlcon;
        private readonly IConfiguration con;
        public Connectionprofile(IConfiguration _con)
        {
            con = _con;
            sqlcon = new SqlConnection(con.GetConnectionString("Quinones"));
        }
        public IEnumerable<Profile> profilelist()
        {
            var sqlstring = "[dbo].[ProfileOptions]";
            return sqlcon.Query<Profile>(sqlstring);
        }
        public void Create(Profile profile)
            
        {
            var sqlstring = "[dbo].[NewProfileDetails]";
            var parameter = new DynamicParameters();
            parameter.Add("@ProfileName", profile.ProfileName, DbType.String, ParameterDirection.Input);
            parameter.Add("@ProfileLastName", profile.ProfileLastName, DbType.String, ParameterDirection.Input);
            parameter.Add("@ProfileMiddleName", profile.ProfileMiddleName, DbType.String, ParameterDirection.Input);
            parameter.Add("@ProfileContactNumber", profile.ProfileContactNumber, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@ProfileAddress", profile.ProfileAddress, DbType.String, ParameterDirection.Input);
            sqlcon.Execute(sqlstring, parameter, commandType: CommandType.StoredProcedure);
        }
        public void ProfileDetailsUpdate(Profile profile)
        {
            var sqlstring = "[dbo].[UpdateProfileDetails]";
            var parameter = new DynamicParameters();
            parameter.Add("@ProfileId", profile.ProfileId, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@ProfileName", profile.ProfileName, DbType.String, ParameterDirection.Input);
            parameter.Add("@ProfileLastName", profile.ProfileLastName, DbType.String, ParameterDirection.Input);
            parameter.Add("@ProfileMiddleName", profile.ProfileMiddleName, DbType.String, ParameterDirection.Input);
            parameter.Add("@ProfileContactNumber", profile.ProfileContactNumber, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@ProfileAddress", profile.ProfileAddress, DbType.String, ParameterDirection.Input);
            sqlcon.Execute(sqlstring, parameter, commandType: CommandType.StoredProcedure);

        }
        public IEnumerable<Profile> PickedProfile(int ProfileId)
        {
            var sqlstring = "[dbo].[DisplayProfileDetails]";
            var parameter = new { ProfileId = ProfileId };
            return sqlcon.Query<Profile>(sqlstring, parameter);
        }
        public void ProfileDetailsDelete(int ProfileId)
        {
            var sqlstring = "[dbo].[DeleteProfileDetails]";
            var parameter = new { ProfileId = ProfileId };
            sqlcon.Execute(sqlstring, parameter, commandType: CommandType.StoredProcedure);
        }
    }
}
