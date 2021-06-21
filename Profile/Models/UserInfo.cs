using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Profile.Models
{
    public class UserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual string EmployeeNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual string LoginName { get; set; }
        public virtual string Password { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string ManagerName { get; set; }
        public virtual string ManagerEmail { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTimeOffset? LastSeenAt { get; set; }
    }
}
