using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQLib.MQModels
{
    internal class MQModel
    {
        public class MQDisplay
        {
            public int MQId { get; set; }
            public string MQName { get; set; }
            public string MQGradeYearLevel { get; set; }
            public string MQReasonForAdmission { get; set; }
            public string MQDate { get; set; }
            public string MQTime { get; set; }
            public string Search { get; set; }
        }
    }
}
