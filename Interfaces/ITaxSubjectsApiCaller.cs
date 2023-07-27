using _19_07_2023_task1.Models;
using _19_07_2023_task1.ViewModels;

namespace _19_07_2023_task1.Interfaces
{
	public interface ITaxSubjectsApiCaller
	{
		public Task<SearchViewModel> GetTaxSubjectByTINAsync(SearchViewModel model);
	}
}
