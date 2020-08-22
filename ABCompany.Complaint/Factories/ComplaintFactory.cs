using ABCompany.Complaint.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ABCompany.Complaint.Factories
{
    public class ComplaintFactory : IComplaintFactory
    {
        /// <summary>
        /// Generates home page complaints
        /// </summary>
        /// <param name="complaints"></param>
        /// <returns></returns>
        public IndexViewModel GenerateIndexViewModel(List<DataModel.Models.Complaint> complaints)
        {
            var indexView = new IndexViewModel();

            if (!complaints.Any()) return indexView;

            indexView.Complaint = new ComplaintViewModel()
            {
                Title = "Previous Complaints",
                Description = "Test Previous Complaint Test Previous Complaints Test Previous ComplaintsTest Previous Complaints",
                Complaints = complaints.Where(e => e.State.ToString() == DataModel.Enum.WorkflowState.Approved.ToString()).ToList()
            };

            return indexView;
        }

        /// <summary>
        /// Generate user view model
        /// </summary>
        /// <param name="complaints">List of complaints</param>
        /// <returns></returns>
        public UserViewModel GenerateUserViewModel(List<DataModel.Models.Complaint> complaints, string Id)
        {
            var userView = new UserViewModel();

            if (!complaints.Any()) return userView;

            userView.Complaints = new ComplaintViewModel()
            {
                Title = "Current Complaints",
                Description = "Test Previous Complaint Test Previous Complaints Test Previous ComplaintsTest Previous Complaints",
                Complaints = complaints.Where(e => e.User.ToString() == Id).ToList()
            };

            return userView;
        }
    }
}