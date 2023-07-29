using _19_07_2023_task1.Data.Entities;
using _19_07_2023_task1.Models;
using _19_07_2023_task1.Services.Interfaces;

namespace _19_07_2023_task1.Services
{
    public class JsonToDataModelConverter : IJsonToDataModelConverter
	{
		public T? GeEntityTypeData<T>(ReceivedSubject taxSubjectApiData)
        {
			if (typeof(T) == typeof(TaxSubject))
			{

                var entityTypeData = ExtractTaxSubjectFromApiData(taxSubjectApiData);

                try
                {
                    return (T)Convert.ChangeType(entityTypeData, typeof(T));
                }
				catch
				{
                    //log
                    throw;
                }
            }
			else if (typeof(T) == typeof(Worker))
			{
                var entityTypeData = new Worker();
                try
                {
                    return (T)Convert.ChangeType(entityTypeData, typeof(T));
                }
                catch
                {
                    //log
                    throw;
                }
            }
            else if (typeof(T) == typeof(Account))
            {
                var entityTypeData = new Account();
                try
                {
                    return (T)Convert.ChangeType(entityTypeData, typeof(T));
                }
                catch
                {
                    //log
                    throw;
                }
            }

            return default(T);
		}

        private TaxSubject ExtractTaxSubjectFromApiData(ReceivedSubject rS)
        {
            var result = new TaxSubject();

            result.Name = rS.Name;
            result.Nip = rS.Nip;
            result.StatusVat = rS.StatusVat;
            result.Regon = rS.Regon;
            result.Pesel = rS.Pesel;
            result.Krs = rS.Krs;
            result.ResidenceAddress = rS.ResidenceAddress;
            result.WorkingAddress = rS.WorkingAddress;
            result.RegistrationLegalDate = rS.RegistrationLegalDate;
            result.RegistrationDenialBasis = rS.RegistrationDenialBasis;
            result.RegistrationDenialDate = rS.RegistrationDenialDate;
            result.RestorationBasis = rS.RestorationBasis;
            result.RestorationDate = rS.RestorationDate;
            result.RemovalBasis = rS.RemovalBasis;
            result.RemovalDate = rS.RemovalDate;
            result.HasVirtualAccounts = rS.HasVirtualAccounts;
            
            return result;

        }
    }
}
