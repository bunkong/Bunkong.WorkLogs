﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bunkong.WorkLogs.DAL
{
    public class WorkLog
    {
        [Key]
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
