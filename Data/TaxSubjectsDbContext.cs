using _19_07_2023_task1.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace _19_07_2023_task1.Data
{
	public class TaxSubjectsDbContext : DbContext
	{
		private IConfiguration _configuration;

        public TaxSubjectsDbContext(IConfiguration configuration)
        {
			_configuration = configuration;
        }

        DbSet<TaxSubject> TaxSubjects { get; set; }
		DbSet<Worker> Workers { get; set; }
		DbSet<Account> Accunts { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:DutchContextDb"]);
		}
	}
}
