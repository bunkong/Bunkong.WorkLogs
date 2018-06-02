using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bunkong.WorkLogs.Database.Schema
{
    public class UserRoles
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        [StringLength(36)]
        public string RoleId { get; set; }
    }
}
