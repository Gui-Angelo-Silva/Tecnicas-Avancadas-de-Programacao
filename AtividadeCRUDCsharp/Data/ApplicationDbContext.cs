using AtividadeCRUDCsharp.Models;
using Microsoft.EntityFrameworkCore;

namespace AtividadeCRUDCsharp.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
		{ 

		}

		public DbSet<MunicipeModel> Municipe { get; set; }
	}
}
