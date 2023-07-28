using _19_07_2023_task1.Data.Repositories.Interfaces;
using _19_07_2023_task1.Models;
using _19_07_2023_task1.Services.Interfaces;

namespace _19_07_2023_task1.Services
{
	public class TaxSubjectDbService : ITaxSubjectDbService
	{
		private readonly ITaxDataSearchRepository _taxDataSearchRepository;

		public TaxSubjectDbService(ITaxDataSearchRepository taxDataSearchRepository)
        {
			_taxDataSearchRepository = taxDataSearchRepository;
		}
        public void SaveReceivedTaxSubjectData(ReceivedSubject data)
		{
			_taxDataSearchRepository.SaveTaxSubjectData(data);
		}
	}
}
