namespace Entities.Concrete.DTOs
{
    public class ProgramLicenseDto
    {
        public int ProgramLicenseID { get; set; }
        public string ProgramName { get; set; }
        public int LicenseID { get; set; }
        public string CustomerName { get; set; }
        public int LicenseType { get; set; }
        public DateTime LicenseStartDate { get; set; }
        public DateTime LicenseEndDate { get; set; }
        public string LicenseDescription { get; set; }
    }
}
