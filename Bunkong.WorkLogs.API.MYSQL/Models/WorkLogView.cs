using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bunkong.WorkLogs.API.MYSQL.Models
{
    public class WorkLogView
    {
        public string Id { get; set; }

        public double WorkHoures { get; set; }
         
        public string WorkContent { get; set; }
         
        public string Remark { get; set; }

        public DateTime WorkDate { get; set; }

        public DateTime LogTime { get; set; }
    }
}
