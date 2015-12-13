using Microsoft.AspNet.Identity.EntityFramework;
using MultiDbContextForeignKeySample.Models;

namespace MultiDbContextForeignKeySample.DataContexts {
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
		public ApplicationDbContext()
			: base("DefaultConnection", throwIfV1Schema: false) {}

		public static ApplicationDbContext Create() {
			return new ApplicationDbContext();
		}

	}
}