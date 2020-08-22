using ABCompany.DataModel.Enum;
using ABCompany.DataModel;
using ABCompany.DataModel.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ABCompany.Complaint.Repository
{
    public class DataModelService : IDataModelService
    {
        public void AddComplaint(DataModel.Models.Complaint complaint)
        {
            using (ABCompanyContext context = new ABCompanyContext())
            {
                context.Complaints.Add(complaint);
            }
        }

        public void UpdateComplaint(DataModel.Models.Complaint complaint)
        {
            using (ABCompanyContext context = new ABCompanyContext())
            {
                context.Complaints.AddOrUpdate(complaint);
            }
        }

        public List<DataModel.Models.Complaint> GetActiveComplaints()
        {
            using (ABCompanyContext context = new ABCompanyContext())
            {
                return context.Complaints
                    .Where(e => e.State.ToString() == WorkflowState.Pending.ToString())
                    .ToList();
            }
        }

        public List<DataModel.Models.Complaint> GetApprovedComplaints()
        {
            using (ABCompanyContext context = new ABCompanyContext())
            {
                return context.Complaints
                    .Where(e => e.State.ToString() == WorkflowState.Approved.ToString())
                    .ToList();
            }
        }

        public List<DataModel.Models.Complaint> GetDiscardComplaints()
        {
            using (ABCompanyContext context = new ABCompanyContext())
            {
                return context.Complaints
                    .Where(e => e.State.ToString() == WorkflowState.Discard.ToString())
                    .ToList();
            }
        }

        public List<DataModel.Models.Complaint> GetComplaints()
        {
            using (ABCompanyContext context = new ABCompanyContext())
            {
                return context.Complaints
                    .ToList();
            }
        }

        public List<User> GetUsers()
        {
            using (ABCompanyContext context = new ABCompanyContext())
            {
                return context.Users
                    .ToList();
            }
        }

        public User GetUsersById()
        {
            using (ABCompanyContext context = new ABCompanyContext())
            {
                return context.Users
                    .FirstOrDefault();
            }
        }

        public void AddUser(User user)
        {
            using (ABCompanyContext context = new ABCompanyContext())
            {
                context.Users.Add(user);
            }
        }

        public void SaveChanges()
        {
            using (ABCompanyContext context = new ABCompanyContext())
            {
                context.SaveChanges();
            }
        }
    }
}