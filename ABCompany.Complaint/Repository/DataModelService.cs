using ABCompany.Complaint.Enum;
using ABCompany.DataModel;
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
            SaveChanges();
        }

        public void UpdateComplaint(DataModel.Models.Complaint complaint)
        {
            using (ABCompanyContext context = new ABCompanyContext())
            {
                context.Complaints.AddOrUpdate(complaint);
            }
            SaveChanges();
        }

        public void SaveChanges()
        {
            using (ABCompanyContext context = new ABCompanyContext())
            {
                context.SaveChanges();
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
    }
}