namespace Workify.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty; 

        // Navigation Properties
        public ICollection<Employer> Employers { get; set; }
        public ICollection<JobListing> JobListings { get; set; }
    }

}
