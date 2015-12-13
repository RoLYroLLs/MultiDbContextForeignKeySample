using System.Data.Entity;
namespace MultiDbContextForeignKeySample.DataContexts {
	public class ClientDbContext : DbContext {
		public ClientDbContext()
			: base("DefaultConnection") { }

		public DbSet<Models.Clients> Clients { get; set; }
	}
}