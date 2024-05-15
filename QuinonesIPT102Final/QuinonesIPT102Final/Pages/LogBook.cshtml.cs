using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MQLib.Models;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace QuinonesIPT102Final.Pages
{
    [BindProperties]
    public class LogBookModel : PageModel
    {
        private readonly ILogger<LogBookModel> _logger;
        private readonly IConfiguration _MQconfig;

        public string Search { get; set; }
        public string MQName { get; set; }
        public string MQGradeYearLevel { get; set; }
        public string MQReasonForAdmission { get; set; }
        public string MQDate { get; set; }
        public string MQTime { get; set; }
        public string MQName2 { get; set; }
        public string MQGradeYearLevel2 { get; set; }
        public string MQReasonForAdmission2 { get; set; }
        public string MQDate2 { get; set; }
        public string MQTime2 { get; set; }
        public int MQId { get; set; }
        public int MQId2 { get; set; }
        public IEnumerable<MQModel.MQDisplay> MQlist { get; set; }
        public LogBookModel(ILogger<LogBookModel> logger, IConfiguration MQconfig)
        {
            _logger = logger;
            _MQconfig = MQconfig;


            var MQconn = new SqlConnection(_MQconfig.GetConnectionString("MQdb"));
            MQlist = MQconn.Query<MQModel.MQDisplay>("[dbo].[MQdisplay]", commandType: CommandType.StoredProcedure);


        }
        public IActionResult OnPostMQcreate()
        {
            var MQconn = new SqlConnection(_MQconfig.GetConnectionString("MQdb"));
            MQconn.Query("[dbo].[MQcreate]", new
            {
                @QBName = MQName,
                @QBGradeYearLevel = MQGradeYearLevel,
                @QBReasonForAdmission = MQReasonForAdmission,
                @QBDate = MQDate,
                @QBTime = MQTime

            }, commandType: CommandType.StoredProcedure);

            return RedirectToPage();
        }
        public IActionResult OnPostMQedit()
        {
            var MQconn = new SqlConnection(_MQconfig.GetConnectionString("MQdb"));
            MQlist = MQconn.Query<MQModel.MQDisplay>("[dbo].[MQdisplay]", commandType: CommandType.StoredProcedure);
            MQName = MQName2;
            MQGradeYearLevel = MQGradeYearLevel2;
            MQReasonForAdmission = MQReasonForAdmission2;
            MQDate = MQDate2;
            MQTime = MQTime2;
            MQId = MQId2;
            return Page();
        }
        public IActionResult OnPostMQsearch()
        {
            var MQconn = new SqlConnection(_MQconfig.GetConnectionString("MQdb"));
            MQlist = MQconn.Query<MQModel.MQDisplay>("[dbo].[MQsearch]", new { @QBkeyword = $"%{Search}%" }, commandType: CommandType.StoredProcedure);

            return Page();
        }

        public IActionResult OnPostMQupdate()
        {
            var MQconn = new SqlConnection(_MQconfig.GetConnectionString("MQdb"));
            MQconn.Query("[dbo].[MQupdate]", new
            {
                @MQId = MQId,
                @MQName = MQName,
                @MQGradeYearLevel = MQGradeYearLevel,
                @MQReasonForAdmission = MQReasonForAdmission,
                @MQDate = MQDate,
                @MQTime = MQTime

            }, commandType: CommandType.StoredProcedure);

            return RedirectToPage();
        }
        public IActionResult OnPostMQdelete()
        {
            var MQconn = new SqlConnection(_MQconfig.GetConnectionString("MQdb"));
            MQconn.Query("[dbo].[MQdelete]", new
            {
                @MQId = MQId

            }, commandType: CommandType.StoredProcedure);

            return RedirectToPage();
        }
    }
}
   

