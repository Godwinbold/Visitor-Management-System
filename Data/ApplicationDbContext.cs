using Microsoft.EntityFrameworkCore;
using Visitor_Management_System.Entities;

namespace Visitor_Management_System.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
		public DbSet<Visitor> Visitors { get; set; }
		public DbSet<Visit> Visits { get; set; }
	}
}
