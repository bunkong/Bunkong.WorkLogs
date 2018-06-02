using System;
using System.ComponentModel.DataAnnotations;

namespace Bunkong.WorkLogs.Database.Schema
{
    public class WorkLog
    {
        /// <summary>
        /// key on string type, adjust for mysql
        /// </summary>
        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        public double WorkHoures { get; set; }

        [MaxLength(500)]
        public string WorkContent { get; set; }

        [MaxLength(90)]
        public string Remark { get; set; }

        public DateTime WorkDate { get; set; }

        public DateTime LogTime { get; set; }
    }
}
