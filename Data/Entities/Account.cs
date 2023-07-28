namespace _19_07_2023_task1.Data.Entities
{
	public class Account
	{
        public Guid AccountId { get; set; }
        public string? AccountNumber { get; set; }
        public Guid TaxSubjectId { get; set; }
        public TaxSubject? TaxSubject { get; set; }
    }
}
