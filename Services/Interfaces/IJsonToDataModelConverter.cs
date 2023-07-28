using _19_07_2023_task1.Data.Entities;

namespace _19_07_2023_task1.Services.Interfaces
{
	public interface IJsonToDataModelConverter
	{
		public Task<TaxSubject> GetDataModelFromJSON(JsonContent json);
	}
}
