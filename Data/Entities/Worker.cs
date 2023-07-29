namespace _19_07_2023_task1.Data.Entities
{
	public class Worker
	{
		public Guid WorkerId { get; set; }
		public string? CompanyName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Nip { get; set; }
		public string? WorkerRole { get; set; }
		public virtual ICollection<TaxSubject>? TaxSubjects { get; set; }
	}
}
