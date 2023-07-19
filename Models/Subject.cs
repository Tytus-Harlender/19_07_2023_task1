namespace _19_07_2023_task1.Models
{
    public class Subject
    {
        public string name { get; set; }
        public string nip { get; set; }
        public string statusVat { get; set; }
        public string regon { get; set; }
        public string pesel { get; set; }
        public string krs { get; set; }
        public string residenceAddress { get; set; }
        public string workingAddress { get; set; }
        public List<object> representatives { get; set; }
        public List<object> authorizedClerks { get; set; }
        public List<object> partners { get; set; }
        public string registrationLegalDate { get; set; }
        public string registrationDenialBasis { get; set; }
        public string registrationDenialDate { get; set; }
        public string restorationBasis { get; set; }
        public string restorationDate { get; set; }
        public string removalBasis { get; set; }
        public string removalDate { get; set; }
        public List<string> accountNumbers { get; set; }
        public bool hasVirtualAccounts { get; set; }
    }
}
