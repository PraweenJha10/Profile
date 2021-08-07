using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Profile.Models
{
	public class UserProfile
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public virtual int ProfileId { get; set; }
		public virtual string ImageUrl { get; set; }
		public virtual string Address { get; set; }
		public virtual string EmployeeNumber { get; set; }
	}
}
