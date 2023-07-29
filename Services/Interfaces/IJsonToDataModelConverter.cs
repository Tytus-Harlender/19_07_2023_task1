using _19_07_2023_task1.Data.Entities;
using _19_07_2023_task1.Models;

namespace _19_07_2023_task1.Services.Interfaces
{
	public interface IJsonToDataModelConverter
	{
		public T? GeEntityTypeData<T>(ReceivedSubject taxSubjectApiData);
	}
}
