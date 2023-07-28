using _19_07_2023_task1.Data.Repositories.Interfaces;
using _19_07_2023_task1.Models;

namespace _19_07_2023_task1.Data.Repositories
{
	public class TaxDataSearchRepository : ITaxDataSearchRepository
	{
		private readonly ILogger _logger;
		private readonly TaxSubjectsDbContext _taxSubjectsDbContext;

		public TaxDataSearchRepository(ILogger logger, TaxSubjectsDbContext taxSubjectsDbContext)
        {
			_logger = logger;
			_taxSubjectsDbContext = taxSubjectsDbContext;
		}
        public async void SaveTaxSubjectData(ReceivedSubject data)
		{
			try
			{
				await _taxSubjectsDbContext.AddAsync(data);
				await _taxSubjectsDbContext.SaveChangesAsync();
			}
			catch (Exception ex) 
			{
				_logger.LogError(ex.Message);
				throw;
			}
		}
	}
}
