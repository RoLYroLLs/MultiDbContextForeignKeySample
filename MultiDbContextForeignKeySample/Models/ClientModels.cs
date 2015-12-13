using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultiDbContextForeignKeySample.Models {
	public class Clients {
		[Key]
		[StringLength(128)]
		public virtual String Id { get; set; }

		[Required]
		[MaxLength(256)]
		[Display(Name = "First Name")]
		public virtual String FirstName { get; set; }

		[Required]
		[StringLength(128)]
		[Display(Name = "Created By")]
		public virtual String CreatedById { get; set; }

		[ForeignKey("CreatedById")]
		public virtual ApplicationUser CreatedBy { get; set; }
	}
}