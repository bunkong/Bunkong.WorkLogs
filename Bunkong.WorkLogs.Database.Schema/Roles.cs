using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bunkong.WorkLogs.Database.Schema
{
    public class Roles
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        /// <summary>
        /// role name
        /// </summary> 
        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(90)]
        public string NameLocale { get; set; } 

        [StringLength(150)]
        public string Remark { get; set; }
    }
}
