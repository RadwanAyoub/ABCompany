using ABCompany.DataModel.Models;
using System.Data.Entity;

namespace ABCompany.DataModel
{
    public class ABCompanyContext : DbContext
    {
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
