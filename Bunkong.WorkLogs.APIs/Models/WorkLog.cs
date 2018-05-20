using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bunkong.WorkLogs.APIs.Models
{
    public class WorkLog
    {
        public Guid Id { get; set; }

        public double WorkHoures { get; set; }

        [MaxLength(500)]
        public string WorkContent { get; set; }

        [MaxLength(90)]
        public string Remark { get; set; }

        public DateTime WorkDate { get; set; }

        public DateTime LogTime { get; set; }
    }
}
