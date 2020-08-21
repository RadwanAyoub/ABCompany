using ABCompany.DataModel.Models;
using System.Collections.Generic;

namespace ABCompany.Complaint.Repository
{
    public interface IDataModelService
    {
        //Complaint
        List<DataModel.Models.Complaint> GetComplaints();
        List<DataModel.Models.Complaint> GetActiveComplaints();
        List<DataModel.Models.Complaint> GetApprovedComplaints();
        List<DataModel.Models.Complaint> GetDiscardComplaints();
        void AddComplaint(DataModel.Models.Complaint complaint);
        void UpdateComplaint(DataModel.Models.Complaint complaint);

        //Users
        List<User> GetUsers();
        User GetUsersById();
        void AddUser(User user);

        //Save Changes
        void SaveChanges();
    }
}
