using System.Data.Entity;

namespace ABCompany.DataModel
{
    public class ABCompanyContext : DbContext
    {
        public DbSet<Complaint.Models.Complaint> Complaints { get; set; }
    }
}
