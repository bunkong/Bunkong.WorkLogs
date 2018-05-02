using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bunkong.WorkLogs.DAL
{
    public class WorkLog
    {
        [Key]
        public Guid Id { get; set; }
    }
}
