using System.Collections.Generic;

namespace ABCompany.Complaint.Repository
{
    public interface IDataModelService
    {
        List<DataModel.Models.Complaint> GetComplaints();
        List<DataModel.Models.Complaint> GetActiveComplaints();
        List<DataModel.Models.Complaint> GetApprovedComplaints();
        List<DataModel.Models.Complaint> GetDiscardComplaints();
        void AddComplaint(DataModel.Models.Complaint complaint);
        void UpdateComplaint(DataModel.Models.Complaint complaint);
        void SaveChanges();
    }
}
