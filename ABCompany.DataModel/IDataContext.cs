using ABCompany.DataModel.Models;
using System.Data.Entity;

namespace ABCompany.DataModel
{
    public interface IDataContext
    {
        DbSet<User> GetUsers();
        DbSet<Complaint> GetComplaints();
        DbContext GetDbContext();
    }
}
