using _19_07_2023_task1.Data.Entities;
using _19_07_2023_task1.Services.Interfaces;

namespace _19_07_2023_task1.Services
{
	public class JsonToDataModelConverter : IJsonToDataModelConverter
	{
		public Task<TaxSubject> GetDataModelFromJSON(JsonContent json)
		{
			return null;
		}
	}
}
