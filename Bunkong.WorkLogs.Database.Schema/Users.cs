using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bunkong.WorkLogs.Database.Schema
{
   public class Users
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(40)]
        public string UserName { get; set; }

        [StringLength(200)]
        public string Password { get; set; }

        [StringLength(20)] 
        public string Name { get; set; }

        [StringLength(80)]
        public string UserFullName { get; set; }
    }
}
